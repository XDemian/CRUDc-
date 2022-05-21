using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemianCRUD.Models.DAO.Repository.ServicoRest.IServicoRest
{
   public interface IBrasilAPIServicoRest
    {
        Task <bool> BuscarCep(string cep);
    }
}
