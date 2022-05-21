using DemianCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemianCRUD.Models.Service.Interface
{
    public interface IPessoaService
    {
        void CadastrarPessoa(Pessoa pessoa);
        Pessoa GetPessoa();

        bool UpdatePessoa(Pessoa pessoa);

        void DeletePessoa(Pessoa pessoa);

        List<Pessoa> SelectAll();

    }
}
