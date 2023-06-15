using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using TopCinema.Models;
using TopCinema.Views;

namespace TopCinema.Controllers
{
    internal class SessaoController
    {
        public static List<SessaoModel> GetSessoes()
        {
            using (var db = new CinemaContext())
            {
                return db.Sessoes.Include("Sala").Include("Filme").Include("ListaBilhetes").ToList();
            }
        }

        public static void AddSessao(DateTime horaInicio, float preco, string nomeSala, string nomeFilme)
        {
            using (var db = new CinemaContext())
            {
                var sessoes = db.Sessoes.Include("Sala").Include("Filme").Where(s => s.Sala.Nome == nomeSala).ToList();
                foreach (var s in sessoes)
                {
                    var duracao = s.Filme.Duracao;
                    var horaFim = s.HoraInicio.AddMinutes(duracao);
                    if (horaInicio >= s.HoraInicio && horaInicio <= horaFim)
                    {
                        throw new Exception("Já existe uma sessão nessa sala nesse horário");
                    }
                }

                var filme = db.Filmes.Where(f => f.Nome == nomeFilme).FirstOrDefault();
                var sala = db.Salas.Where(s => s.Nome == nomeSala).FirstOrDefault();

                var sessao = new SessaoModel(horaInicio, preco, sala, filme);
                db.Sessoes.Add(sessao);
                db.SaveChanges();
            }
        }

        public static void DeleteSessao(int idSessao)
        {
            using (var db = new CinemaContext())
            {
                var sessao = db.Sessoes.Find(idSessao);
                db.Sessoes.Remove(sessao);
                db.SaveChanges();
            }
        }

        public static void AlterarSessao(int idSessao, DateTime horaInicio, float preco, int idFilme)
        {
            using (var db = new CinemaContext())
            {
                var sessao = db.Sessoes.Find(idSessao);
                var filme = db.Filmes.Find(idFilme);
                sessao.HoraInicio = horaInicio;
                sessao.Preco = preco;
                sessao.Filme = filme;
                db.SaveChanges();
            }
        }

        public static int GetLugaresLivres(SessaoModel sessao)
        {
            var bilhetes = sessao.ListaBilhetes;
            var lugaresLivres = sessao.Sala.Colunas * sessao.Sala.Filas;
            lugaresLivres -= bilhetes.Count;
            return lugaresLivres;
        }

        static public bool AssentoOcupado(int idSessao, int fila, int coluna)
        {
            using (var db = new CinemaContext())
            {
                var sessao = db.Sessoes.Include("ListaBilhetes").Where(s => s.Id == idSessao).FirstOrDefault();
                var bilhetes = sessao.ListaBilhetes;
                foreach (var b in bilhetes)
                {
                    if (b.Fila == fila && b.Coluna == coluna)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        static public List<BilheteModel> GetBilhetesSessao(int idSessao)
        {
            using (var db = new CinemaContext())
            {
                var sessao = db.Sessoes.Include("ListaBilhetes").Where(s => s.Id == idSessao).FirstOrDefault();
                return sessao.ListaBilhetes;
            }
        }

        static public void AdicionarReserva(int idSessao, string nomeFuncionario, int nifCliente, int fila, int coluna)
        {
            using (var db = new CinemaContext())
            {
                var bilhete = new BilheteModel(fila, coluna);
                var sessao = db.Sessoes.Include("ListaBilhetes").Where(s => s.Id == idSessao).FirstOrDefault();
                var funcionario = db.Funcionarios.Where(f => f.Nome == nomeFuncionario).Include("BilhetesEmitidos").FirstOrDefault();
                var cliente = db.Clientes.Include("ListaBilhetes").Where(c => c.Nif == nifCliente).FirstOrDefault();

                if (funcionario == null)
                {
                    throw new Exception("Não existe nenhum funcionário com esse nome!");
                }

                if (cliente == null)
                {
                    throw new Exception("Não existe nenhum cliente com esse NIF!");
                }

                if (sessao.ListaBilhetes.Where(b => b.Fila == fila && b.Coluna == coluna).FirstOrDefault() != null)
                {
                    throw new Exception("O lugar já está ocupado!");
                }

                sessao.ListaBilhetes.Add(bilhete);
                funcionario.BilhetesEmitidos.Add(bilhete);
                cliente.ListaBilhetes.Add(bilhete);
                db.Bilhetes.Add(bilhete);

                db.SaveChanges();
            }
        }

        static public void EmitirRecibo(int idSessao, int nifCliente, int fila, int coluna, string nomeFuncionario)
        {
            using (var db = new CinemaContext())
            {
                var sessao = db.Sessoes.Include("Filme").Include("Sala").Include("ListaBilhetes").Where(s => s.Id == idSessao).FirstOrDefault();
                var cliente = db.Clientes.Include("ListaBilhetes").Where(c => c.Nif == nifCliente).FirstOrDefault();
                var bilhete = sessao.ListaBilhetes.Where(b => b.Fila == fila && b.Coluna == coluna).FirstOrDefault();

                var nomeCliente = cliente.Nome;
                var nif = cliente.Nif;
                var nomeFilme = sessao.Filme.Nome;
                var horaInicio = sessao.HoraInicio;
                var preco = sessao.Preco;
                var dataHoraEmissao = DateTime.Now;
                var nomeSala = sessao.Sala.Nome;

                using (StreamWriter sw = File.AppendText("recibos.txt"))
                {
                    sw.WriteLine("==================================================");
                    sw.WriteLine("Nome do cliente: " + nomeCliente);
                    sw.WriteLine("NIF: " + nif);
                    sw.WriteLine("Nome do filme: " + nomeFilme);
                    sw.WriteLine("Hora de inicio: " + horaInicio);
                    sw.WriteLine("Preco: " + preco);
                    sw.WriteLine("Nome do funcionario: " + nomeFuncionario);
                    sw.WriteLine("Data e hora da emissao do recibo: " + dataHoraEmissao);
                    sw.WriteLine("Sala: " + nomeSala);
                    sw.WriteLine("Fila: " + fila);
                    sw.WriteLine("Coluna: " + coluna);
                    sw.WriteLine("==================================================");
                }
            }
        }

        static public float GetTotalArrecadado()
        {
            using (var db = new CinemaContext())
            {
                var sessoes = db.Sessoes.Include("ListaBilhetes").ToList();
                var total = 0.0f;
                foreach (var s in sessoes)
                {
                    total += s.ListaBilhetes.Count * s.Preco;
                }
                return total;
            }
        }
    }
}
