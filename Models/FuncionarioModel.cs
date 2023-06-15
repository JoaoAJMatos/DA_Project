using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCinema.Models
{
    internal class FuncionarioModel : PessoaModel
    {
        public float Salario { get; set; }
        public string Funcao { get; set; }
        public List<BilheteModel> BilhetesEmitidos { get; set; }

        public FuncionarioModel() : base() { }

        public FuncionarioModel(string nome, string morada, float salario, string funcao) : base(nome, morada)
        {
            Salario = salario;
            Funcao = funcao;
            BilhetesEmitidos = new List<BilheteModel>();
        }
    }
}
