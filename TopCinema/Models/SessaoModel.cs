using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCinema.Models
{
    internal class SessaoModel
    {
        public DateTime DataHora { get; set; }
        public float Preco { get; set;}
        public FilmeModel FilmeModel { get; set; }
        public List<BilheteModel> BilheteModel { get; set; }
    }
}
