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
        public static List<ClienteModel> GetClientes()
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
                var cliente = db.Clientes.Where(c => c.Nif == nif).FirstOrDefault();

                if (cliente != null)
                {
                    throw new Exception("Já existe um cliente com esse NIF!");
                }

                cliente = new ClienteModel(nome, morada,nif);
                db.Clientes.Add(cliente);
                db.SaveChanges();
            }
        }

        public static void RemoveCliente(int idCliente)
        {
            using (var db = new CinemaContext())
            {
                var cliente = db.Clientes.Find(idCliente);
                db.Clientes.Remove(cliente);
                db.SaveChanges();
            }
        }

        public static void AlterarCliente(int idCliente, string nome, string morada, int nif)
        {
            using (var db = new CinemaContext())
            {
                var clienteRes = db.Clientes.Where(c => c.Nif == nif).FirstOrDefault();

                if (clienteRes != null && clienteRes.Id != idCliente)
                {
                    throw new Exception("Já existe um cliente com esse NIF!");
                }

                var cliente = db.Clientes.Find(idCliente);
                cliente.Nome = nome;
                cliente.Morada = morada;
                cliente.Nif = nif;
                db.SaveChanges();
            }
        }

        public static ClienteModel GetClientePorNIF(string NIF)
        {
            int nif = 0;
            
            if (!int.TryParse(NIF, out nif))
            {
                throw new Exception("NIF inválido!");
            }

            using (var db = new CinemaContext())
            {
                return db.Clientes.Where(c => c.Nif == nif).FirstOrDefault();
            }
        }

        public static int GetBilhetesComprados(int idCliente)
        {
            using (var db = new CinemaContext())
            {
                var cliente = db.Clientes.Include("ListaBilhetes").Where(c => c.Id == idCliente).FirstOrDefault();
                return cliente.ListaBilhetes.Count;
            }
        }

        public static float GetValorGasto(int idCliente)
        {
            using (var db = new CinemaContext())
            {
                var sessoes = db.Sessoes.Include("Sala").Include("Filme").Include("ListaBilhetes").ToList();
                var cliente = db.Clientes.Include("ListaBilhetes").Where(c => c.Id == idCliente).FirstOrDefault();
                var bilhetes = cliente.ListaBilhetes;
                float valorTotal = 0;

                foreach (var bilhete in bilhetes)
                {
                    var sessao = sessoes.Where(s => s.ListaBilhetes.Contains(bilhete)).FirstOrDefault();
                    float preco = sessao.Preco;
                    valorTotal += preco;
                }

                return valorTotal;
            }
        }
    }
}
