using DemianCRUD.Models.DAO.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemianCRUD.Models.DAO.Repository
{


    public class PessoaRepository : IPessoaRepository
    {
       public  DemianCRUDContext _demianCRUDContext;
        public PessoaRepository(DemianCRUDContext demianCRUDContext)
        {
            _demianCRUDContext = demianCRUDContext;
        }

        public void CadastrarPessoa(Pessoa pessoa)
        {
            _demianCRUDContext.Pessoa.Add(pessoa);

            _demianCRUDContext.SaveChanges();
        }

        public Pessoa GetPessoa()
        {

            return _demianCRUDContext.Pessoa.Where(x => x.id != 0).FirstOrDefault();

        }

        public List<Pessoa> SelectAll()
        {
            return _demianCRUDContext.Pessoa.Where(x => x.id != 0).ToList();
        }

        public void UpdatePessoa(Pessoa pessoa)
        {

            _demianCRUDContext.Pessoa.Update(pessoa);
            _demianCRUDContext.SaveChanges();
        }

        public void DeletePessoa(Pessoa pessoa)
        {
            _demianCRUDContext.Pessoa.Remove(pessoa);
            _demianCRUDContext.SaveChanges();

        }
    }
}
