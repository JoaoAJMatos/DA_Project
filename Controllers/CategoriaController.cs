using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TopCinema.Models;

namespace TopCinema.Controllers
{
    internal class CategoriaController
    {
        public static readonly List<string> _categoriasAceites = new List<string> { "Comédia", "Sci-fi", "Terror",
                                                                              "Romance", "Acção", "Thriller",
                                                                              "Drama", "Mistério", "Crime",
                                                                              "Aventura", "Fantasia ou Animação" };

        public static void AddCategoriaIfNotExists(string nomeCategoria, bool estado)
        {
            using (var db = new CinemaContext())
            {
                var categoria = new CategoriaModel(nomeCategoria, estado);

                var categoriaExists = db.Categorias.Where(c => c.Nome == categoria.Nome).FirstOrDefault();
                if (categoriaExists == null)
                {
                    db.Categorias.Add(categoria);
                    db.SaveChanges();
                }
            }
        }
    }
}
