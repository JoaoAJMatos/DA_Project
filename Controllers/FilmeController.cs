using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TopCinema.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace TopCinema.Controllers
{
    internal class FilmeController
    {
        public static List<FilmeModel> GetFilmes()
        {
            using (var db = new CinemaContext())
            {
                return db.Filmes.Include("Categoria").ToList();
            }
        }
        
        public static void AddFilme(string nome, int duracao, string nomeCategoria, bool estado)
        {
            using (var db = new CinemaContext())
            {
                var filmeExists = db.Filmes.Where(f => f.Nome == nome).FirstOrDefault();
                if (filmeExists != null)
                {
                    throw new Exception("O filme '" + nome + "' já existe.");
                }

                if (!CategoriaController._categoriasAceites.Contains(nomeCategoria))
                {
                    throw new Exception("A categoria '" + nomeCategoria + "' não é aceite.");
                }

                var categoria = new CategoriaModel(nomeCategoria, estado);
                var filme = new FilmeModel(nome, duracao, categoria);

                db.Filmes.Add(filme);
                db.SaveChanges();
            }
        }
        
        public static void RemoverFilme(int id)
        {
            using (var db = new CinemaContext())
            {
                var filme = db.Filmes.Find(id);
                db.Filmes.Remove(filme);
                db.SaveChanges();
            }
        }

        public static void AlterarFilme(int idFilme, string nome, int duracao, string categoria, bool ativo)
        {
            using (var db = new CinemaContext())
            {
                var filme = db.Filmes.Find(idFilme);
                filme.Nome = nome;
                filme.Duracao = duracao;

                if (!CategoriaController._categoriasAceites.Contains(categoria))
                {
                    throw new Exception("A categoria '" + categoria + "' não é aceite.");
                }

                var categoriaModel = new CategoriaModel(categoria, true);
                filme.Categoria = categoriaModel;
                filme.Ativo = ativo;
                db.SaveChanges();
            }
        }
    }
}
