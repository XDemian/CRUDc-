using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DemianCRUD.Models.Utils
{
    public static class Validation
    {
        public static bool ValidarPessoa(Pessoa pessoa)
        {
            
            if (ValidarCPF(pessoa.Cpf) && ValidarEmail(pessoa.email) && ValidarTelefone(pessoa.telefone))
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
            var telefoneVAlidacaoRegex = @"^[\(][0-9]{2}[\)][0-9]{5}[\-][0-9]{4}$";

            var _regex = new Regex(telefoneVAlidacaoRegex);
            return _regex.IsMatch(telefone);
        }
    }
}
