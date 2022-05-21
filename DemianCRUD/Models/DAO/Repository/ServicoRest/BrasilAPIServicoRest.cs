using DemianCRUD.Models.DAO.Repository.ServicoRest.IServicoRest;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Xml;

namespace DemianCRUD.Models.DAO.Repository.ServicoRest
{
    public class BrasilAPIServicoRest : IBrasilAPIServicoRest
    {
        public async Task<bool> BuscarCep(string cep)
        {
            var client = new RestClient("https://brasilapi.com.br/api/cep/v1/" + cep);
            var request = new RestRequest( "" , Method.Get);

            var response = await client.ExecuteAsync(request).ConfigureAwait(false);
            Console.WriteLine(response.Content);
            var objetoJason = JsonConvert.DeserializeObject<JsonCep>(response.Content);
           return  objetoJason.cep != null;
    
        }
    }
}

public class JsonCep
{
    public string cep { get; set; }

    public string state { get; set; }

    public string cyti { get; set; }

    public string neighborhood { get; set; }
    public string street { get; set; }
    public string service { get; set; }

}
