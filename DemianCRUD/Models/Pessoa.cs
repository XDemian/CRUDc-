using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DemianCRUD.Models
{

    public class Pessoa
    {
        public Pessoa() {
            
            var listLinguaEstrangeira = new List<string>();
            listLinguaEstrangeira.Add("Inglês");
            listLinguaEstrangeira.Add("Espanhol");
            listLinguaEstrangeira.Add("Francês");
            SelectList _select = new SelectList(listLinguaEstrangeira);
            this.listLinguaEstrangeira = _select;


        }
        public int id { get; set; }
        public string nome { get; set; } //Texto livre

        public string Cpf { get; set; } // Validar o CPF
        public string email { get; set; } // Validar o e-mail

        public string telefone { get; set; } //Validar o formato do telefone (XX) XXXXX-XXXX
        public bool habilitacao { get; set; } //Sim / Não

        public string categoria { get; set; } // Texto livre. Só mostrar este campo se o campo Habilitação for marcado como Sim.

        [NotMapped]
        public SelectList listLinguaEstrangeira { get; set; }// Campo de múltiplas opções com os itens: Inglês, Espanhol e Francês.

        public string linguaEstrangeira { get; set; }
        public string estado { get; set; } // Buscar o estado a partir de algum serviço web. Não utilizar a mesma busca do CEP.
        public string cidade { get; set; } // Buscar a cidade a partir de algum serviço web, filtrando pelo estado. Não utilizar a mesma busca do CEP.

        public string cep { get; set; } // Validar o formato do CEP

        public string logadouro { get; set; } // Carregar a partir do CEP, utilizando algum serviço web
        public int? numero { get; set; }// Carregar a partir do CEP, utilizando algum serviço web

        public string? complemento { get; set; } // texto livre

        public string? cargo { get; set; } // Criar uma lista fixa de 5 cargos para o usuário escolher

        public string? salarioProposto { get; set; } // Validar o formato: XX.XXX,XX

    }
}
