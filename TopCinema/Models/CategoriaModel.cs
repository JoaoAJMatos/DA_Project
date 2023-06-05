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
        public string Name { get; set; }
        public bool Activa { get; set; }

        public CategoriaModel(string name,bool activa) {
            Name = name;
            Activa = activa;
        
        } 
    }
}
