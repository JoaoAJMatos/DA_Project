using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCinema.Models
{
    public class BilheteModel
    {
        public int Id { get; set; }
        public int Fila { get; set; }
        public int Coluna { get; set; }
        public string LugarStr { get; set; }
        public bool Usado { get; set; }

        public BilheteModel() { }

        public BilheteModel(int fila, int coluna)
        {
            Fila = fila;
            Coluna = coluna;
            LugarStr = fila + "-" + coluna;
            Usado = false;
        }
    }
}
