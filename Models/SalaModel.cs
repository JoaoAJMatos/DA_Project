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
        public string Name { get; set; }
        public int Colunas { get; set; }
        public int Filas { get; set; }
        public List<SessaoModel> SessaoModel { get; set; }

        public SalaModel(string name,int colunas, int filas) {
            Name = name;
            Colunas = colunas;
            Filas = filas;
            SessaoModel = new List<SessaoModel>();
        }
        public SalaModel() {}

        public override string ToString()
        {
            return this.Name + "Colunas: " + this.Colunas + "Filas: " + this.Filas;
        }
    }
}
