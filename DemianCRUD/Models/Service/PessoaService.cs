
using DemianCRUD.Models.DAO;
using DemianCRUD.Models.DAO.Repository.Interface;
using DemianCRUD.Models.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemianCRUD.Models.Service
{
    public class PessoaService : IPessoaService
    {
        public IPessoaRepository _pessoaRepository;
        public PessoaService(IPessoaRepository demianCRUDRepository)
        {
            _pessoaRepository = demianCRUDRepository;
        }

        public void CadastrarPessoa(Pessoa pessoa )
        {

            if ( pessoa.id == 0 && pessoa.nome != null  )
            {
                _pessoaRepository.CadastrarPessoa(pessoa);
            }
         
        }

        public Pessoa GetPessoa()
        {
            return _pessoaRepository.GetPessoa();
        }

        public List<Pessoa> SelectAll()
        {
            return _pessoaRepository.SelectAll();
        }

        public void UpdatePessoa(Pessoa pessoa)
        {
            if (pessoa.id > 0)
            {
                _pessoaRepository.UpdatePessoa(pessoa);
            }
        }

        public void DeletePessoa(Pessoa pessoa)
        {
            _pessoaRepository.DeletePessoa(pessoa);
         
        }

    }
}
