using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCinema.Models
{
    internal class CategoriaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativa { get; set; }

        public CategoriaModel() { }

        public CategoriaModel(string nome, bool ativa) 
        {
            Nome = nome;
            Ativa = ativa;
        }
    }
}
