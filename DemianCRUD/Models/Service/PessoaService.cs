
using DemianCRUD.Models.DAO;
using DemianCRUD.Models.DAO.Repository.Interface;
using DemianCRUD.Models.DAO.Repository.ServicoRest.IServicoRest;
using DemianCRUD.Models.Service.Interface;
using DemianCRUD.Models.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DemianCRUD.Models.Service
{
    public class PessoaService : IPessoaService
    {
        public IPessoaRepository _pessoaRepository;
        public IBrasilAPIServicoRest _brasilAPIServicoRest;
        private string cpfValidacaoRegex;

        public PessoaService(IPessoaRepository demianCRUDRepository, IBrasilAPIServicoRest brasilAPIServicoRest)
        {
            _pessoaRepository = demianCRUDRepository;
            _brasilAPIServicoRest = brasilAPIServicoRest;
        }

        public void CadastrarPessoa(Pessoa pessoa  )
        {
            if ( pessoa.id == 0 && pessoa.nome != null  )
            {
                //cpfValidacaoRegex = @"^[0-9]{3}[\.][0-9]{3}[\.][0-9]{3}[\-][0-9]{2}$";
                //var _regex = new Regex(cpfValidacaoRegex);

                if(Validation.ValidarPessoa(pessoa, _brasilAPIServicoRest)){
                    _pessoaRepository.CadastrarPessoa(pessoa );
                }
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

        public bool UpdatePessoa(Pessoa pessoa)
        {
            var  testePessoa = _pessoaRepository.SelectPessoaById(pessoa.id);
            if (testePessoa.habilitacao != pessoa.habilitacao
            ||  testePessoa.linguaEstrangeira != pessoa.linguaEstrangeira
            || testePessoa.logadouro != pessoa.logadouro
            || testePessoa.nome != pessoa.nome
            || testePessoa.numero != pessoa.numero
            || testePessoa.telefone != pessoa.telefone
            || testePessoa.categoria != pessoa.categoria
            || testePessoa.cep != pessoa.cep
            || testePessoa.cidade != pessoa.cidade
            || testePessoa.Cpf != pessoa.Cpf
            || testePessoa.email != pessoa.email
            || testePessoa.complemento != pessoa.complemento
            || testePessoa.cargo != pessoa.cargo 
            || testePessoa.salarioProposto != pessoa.salarioProposto)
            {
                _pessoaRepository.UpdatePessoa(pessoa);
                return true;
            } return false;
        }

        public void DeletePessoa(Pessoa pessoa)
        {
            _pessoaRepository.DeletePessoa(pessoa);
         
        }

    }
}
