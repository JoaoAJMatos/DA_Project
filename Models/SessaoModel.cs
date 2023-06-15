using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCinema.Models
{
    internal class SessaoModel
    {
        public int Id { get; set; }
        public DateTime HoraInicio { get; set; }
        public float Preco { get; set;}
        public SalaModel Sala { get; set; }
        public FilmeModel Filme { get; set; }
        public List<BilheteModel> ListaBilhetes { get; set; }

        public SessaoModel() { }

        public SessaoModel(DateTime horaInicio, float preco, SalaModel sala, FilmeModel filme)
        {
            HoraInicio = horaInicio;
            Preco = preco;
            Sala = sala;
            Filme = filme;
            ListaBilhetes = new List<BilheteModel>();
        }
    }
}
