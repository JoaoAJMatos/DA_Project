using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TopCinema.Models;

namespace TopCinema.Controllers
{
    internal class ClienteController
    {
        internal static List<ClienteModel> GetClientes()
        {
            using (var db = new CinemaContext())
            {
                return db.Clientes.ToList();
            }
        }

        public static void AddCliente(string nome, string morada, int nif)
        {
            using (var db = new CinemaContext())
            {
                var cliente = new ClienteModel(nome, morada,nif);
                db.Clientes.Add(cliente);
                db.SaveChanges();
            }
        }

        public static void RemoveCliente(ClienteModel cliente)
        {
            using (var db = new CinemaContext())
            {
                cliente = db.Clientes.Find(cliente.Id);
                db.Clientes.Remove(cliente);
                db.SaveChanges();
            }
        }

        public static void AlterarCliente(ClienteModel cleinte, string nome, string morada, int nif)
        {
            using (var db = new CinemaContext())
            {
                cleinte = db.Clientes.Find(cleinte.Id);
                cleinte.Name = nome;
                cleinte.Morada = morada;
                cleinte.NumFiscal = nif;
                db.SaveChanges();
            }
        }




    }
}
