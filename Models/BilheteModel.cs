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
        public int Lugar { get; set; }
        public bool Estado { get; set; }

        public BilheteModel(int lugar, bool estado)
        {
            Lugar = lugar;
            Estado = estado;
        }

        public void GetBilhete()
        { 
        }
    }

    
}
