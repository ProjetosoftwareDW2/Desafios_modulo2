using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itemindicador.Models
{
    public class Indicador
    {
        public int Indicador_Id { get; set; }
        public string Nome { get; set; }

        public List<Indicador> ListaIndicador()
        {
            return new List<Indicador>
            {
                new Indicador { Indicador_Id = 1, Nome = "Desafio"},
                new Indicador { Indicador_Id = 2, Nome = "Projeto"},
                new Indicador { Indicador_Id = 3, Nome = "Exercício"}
            };
        }
    }
}