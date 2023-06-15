using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

using TopCinema.Models;

namespace TopCinema.Controllers
{
    internal class SalaController
    {
        public static List<SalaModel> GetSalas()
        {
            using (var db = new CinemaContext())
            {
                return db.Salas.ToList();
            }
        }

        public static void AddSala(string nome, int colunas, int filas)
        {
            using (var db = new CinemaContext())
            {
                var salaRes = db.Salas.Where(s => s.Nome == nome).FirstOrDefault();
                if (salaRes != null)
                {
                    throw new Exception("Já existe uma sala com esse nome!");
                }

                var sala = new SalaModel(nome, colunas, filas);
                db.Salas.Add(sala);
                db.SaveChanges();
            }
        }

        public static void DeleteSala(int idSala)
        {
            using (var db = new CinemaContext())
            {
                var sala = db.Salas.Find(idSala);
                db.Salas.Remove(sala);
                db.SaveChanges();
            }
        }

        public static void AlterarSala(int idSala, string nome, int coluna, int fila)
        {
            using (var db = new CinemaContext())
            {
                var sala = db.Salas.Find(idSala);
                sala.Nome = nome;
                sala.Colunas = coluna;
                sala.Filas = fila;
                db.SaveChanges();
            }
        }

        public static List<int> GetSalaFilasColunas(string salaNome)
        {
            List<int> filasColunas = new List<int>();

            using (var db = new CinemaContext())
            {
                var sala = db.Salas.Where(s => s.Nome == salaNome).FirstOrDefault();
                filasColunas.Add(sala.Filas);
                filasColunas.Add(sala.Colunas);
            }

            return filasColunas;
        }
    }
}
