using DemianCRUD.Models;
using DemianCRUD.Models.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemianCRUD.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public IPessoaService _iPessoaService;

        public HomeController(ILogger<HomeController> logger , IPessoaService ipessoaService )
        {
            _iPessoaService = ipessoaService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var retornaPessoa = _iPessoaService.GetPessoa();
            return View();
        }


        public IActionResult Delete(Pessoa pessoa)
        {
            _iPessoaService.DeletePessoa(pessoa);
            return RedirectToAction("Listagem");
        }

        public IActionResult Update(Pessoa pessoa)
        {
            if (!_iPessoaService.UpdatePessoa(pessoa))
            {
                return View(pessoa);
            } else return RedirectToAction("Listagem");



        }

        //[HttpPost]
        public IActionResult InsertPessoa(Pessoa pessoa)
        {
            _iPessoaService.CadastrarPessoa(pessoa);

            if(pessoa.id > 0 && pessoa.nome != null)
            {
                return RedirectToAction("Listagem");
            }
            return View();
        }

        public IActionResult Listagem()
        {
            return View(_iPessoaService.SelectAll());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
