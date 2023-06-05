using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCinema.Models
{
    internal class FilmeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Duracao { get; set; }
        public bool Activo { get; set; }
        public CategoriaModel CategoriaModel { get; set; }

        public FilmeModel(string name,bool activo) {
            Name = name;
            Activo = activo;
            Duracao = DateTime.Now;
            CategoriaModel = new CategoriaModel(name,activo);
        }

        public virtual string GetFilme()
        {
            return this.Name + "\n" + this.Duracao + "\n" + this.Activo + "\n";
        }
    }
}
