using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCinema.Models
{
    internal class PessoaModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Morada { get; set; }

        public PessoaModel(string name,string morada) {
            Name = name;
            Morada = morada;
        }

        public PessoaModel()
        {
            
        }

        public override string ToString()
        {
            return this.Name + "\n" + this.Morada + "\n";
        }
    }
}
