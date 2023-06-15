using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCinema.Models
{
    internal class SalaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Colunas { get; set; }
        public int Filas { get; set; }
        public List<SessaoModel> ListaSessoes { get; set; }

        public SalaModel() { }

        public SalaModel(string nome, int colunas, int filas) 
        {
            Nome = nome;
            Colunas = colunas;
            Filas = filas;
            ListaSessoes = new List<SessaoModel>();
        }
    }
}
