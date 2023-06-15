using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TopCinema.Models;

namespace TopCinema.Controllers
{
    internal class CinemaController
    {
        public static CinemaModel GetCinema()
        {
            using (var db = new CinemaContext())
            {
                var cinema = db.Cinemas.FirstOrDefault();
                if (cinema == null)
                {
                    throw new Exception("Não existe nenhum cinema na base de dados!");
                }

                return cinema;
            }
        }

        public static bool CinemaExists()
        {
            using (var db = new CinemaContext())
            {
                return db.Cinemas.Count() > 0;
            }
        }

        public static void AddCinema(string nome, string morada, string email)
        {
            using (var db = new CinemaContext())
            {
                if (db.Cinemas.Count() > 0)
                {
                    throw new Exception("Já existe um cinema na base de dados!");
                }

                var cinema = new CinemaModel(nome, morada, email);
                db.Cinemas.Add(cinema);
                db.SaveChanges();
            }
        }

        public static void EditCinema(string nome, string morada, string email)
        {
            using (var db = new CinemaContext())
            {
                var cinema = db.Cinemas.FirstOrDefault();
                cinema.Name = nome;
                cinema.Morada = morada;
                cinema.Email = email;
                db.SaveChanges();
            }
        }
    }
}
