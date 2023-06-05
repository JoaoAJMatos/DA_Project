using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TopCinema.Models;

namespace TopCinema.Controllers
{
    internal class SalaController
    {
        public static void AddSala(string nome,int coluna,int fila)
        {
            using (var db = new CinemaContext())
            {
                var sala = new SalaModel(nome,coluna,fila);
                db.Salas.Add(sala);
                db.SaveChanges();
            }
        }

        internal static List<SalaModel> GetSalas()
        {
            using (var db = new CinemaContext())
            {
                return db.Salas.ToList();
            }
        }

        public static void DeleteSala(SalaModel sala)
        {
            using (var db = new CinemaContext())
            {
                sala=db.Salas.Find(sala.Id);

                db.Salas.Remove(sala);
                db.SaveChanges();
            }
        }

        public static void AlterarSala(SalaModel sala, string nome, int coluna, int fila)
        {
            using (var db = new CinemaContext())
            {
                sala = db.Salas.Find(sala.Id);
                sala.Name = nome;
                sala.Colunas = coluna;
                sala.Filas = fila;
                db.SaveChanges();
            }
        }
    }
}
