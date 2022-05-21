using DemianCRUD.Models.DAO.Repository.ServicoRest;
using DemianCRUD.Models.DAO.Repository.ServicoRest.IServicoRest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace DemianCRUD.Models.Utils
{
    public static class Validation
    {
        public static bool ValidarPessoa(Pessoa pessoa , IBrasilAPIServicoRest _IbrasilAPIServicoRest)
        {
            
            if (ValidarCPF(pessoa.Cpf) && ValidarEmail(pessoa.email) 
                && ValidarTelefone(pessoa.telefone) && ValidarCEP(pessoa.cep , _IbrasilAPIServicoRest))
            {
                return true;
            }
            return false;
        }

        public static bool ValidarCPF(string cpf)
        {
            var cpfValidacaoRegex = @"^[0-9]{3}[\.][0-9]{3}[\.][0-9]{3}[\-][0-9]{2}$";
            var _regex = new Regex(cpfValidacaoRegex);

           return _regex.IsMatch(cpf);
         
        }

        public static bool ValidarEmail(string email)
        {
            var emailValidacaoRegex = @"^[a-z0-9-_.><*]+[\@][a-z0-9-_.><*]+[\.][a-z]+$";
            var _regex = new Regex(emailValidacaoRegex);
            return _regex.IsMatch(email.ToLower());
        }

        public static bool ValidarTelefone(string telefone)
        {
            var telefoneValidacaoRegex = @"^[\(][0-9]{2}[\)][0-9]{5}[\-][0-9]{4}$";

            var _regex = new Regex(telefoneValidacaoRegex);
            return _regex.IsMatch(telefone);
        }

        public static bool ValidarCEP(string cep , IBrasilAPIServicoRest _brasilAPIServicoRest)
        {
            var cepValidacaoRegex = @"^[0-9]{5}[\-][0-9]{3}$";
            var _regex = new Regex(cepValidacaoRegex);

            if (_regex.IsMatch(cep))
            {
                return  _brasilAPIServicoRest.BuscarCep(cep).Result;
            }
            return false;
        }




    }
}
