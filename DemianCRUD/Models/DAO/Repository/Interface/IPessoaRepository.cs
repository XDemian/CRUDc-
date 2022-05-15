using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemianCRUD.Models.DAO.Repository.Interface
{
    public interface IPessoaRepository
    {
        void CadastrarPessoa(Pessoa pessoa);
        Pessoa GetPessoa();
        List<Pessoa> SelectAll();
        void UpdatePessoa(Pessoa pessoa);

        void DeletePessoa(Pessoa pessoa);
    }
}
