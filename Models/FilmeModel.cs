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
        public string Nome { get; set; }
        public int Duracao { get; set; }
        public bool Ativo { get; set; }
        public CategoriaModel Categoria { get; set; }

        public FilmeModel() { }

        public FilmeModel(string nome, int duracao, CategoriaModel categoria) 
        {
            Nome = nome;
            Ativo = false;
            Duracao = duracao;
            Categoria = categoria;
        }
    }
}
