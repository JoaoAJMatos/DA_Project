using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TopCinema.Models;

namespace TopCinema.Controllers
{
    internal class BilheteController : CinemaContext
    {
        
        public static List<BilheteModel> GetBilhete() {
            using (var db = new CinemaContext())
            {
                return db.Bilhetes.ToList();
            }
        }

    }
}
