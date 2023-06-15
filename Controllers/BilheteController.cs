using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

using TopCinema.Models;
using TopCinema.Views;

namespace TopCinema.Controllers
{
    internal class BilheteController
    {
        public static List<BilheteModel> GetBilhetes() 
        {
            using (var db = new CinemaContext())
            {
                return db.Bilhetes.ToList();
            }
        }

        public static void AtivarBilhete(int idBilhete)
        {
            using (var db = new CinemaContext())
            {
                var bilhete = db.Bilhetes.Find(idBilhete);
                bilhete.Usado = true;
                db.SaveChanges();
            }
        }
    }
}
