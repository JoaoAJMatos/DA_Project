using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCinema.Models
{
    internal class FilmeModel
    {
        public string Name { get; set; }
        public DateTime Duracao { get; set; }
        public bool Activo { get; set; }
        public CategoriaModel CategoriaModel { get; set; }
    }
}
