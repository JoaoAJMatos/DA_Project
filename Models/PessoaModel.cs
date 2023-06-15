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
        public string Nome { get; set; }
        public string Morada { get; set; }

        public PessoaModel() { }

        public PessoaModel(string nome, string morada) 
        {
            Nome = nome;
            Morada = morada;
        }
    }
}
