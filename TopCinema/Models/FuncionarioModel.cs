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
        public List<BilheteModel> BilheteModel { get; set; }

        /*public FuncionarioModel(float salario,string funcao) {
            Salario = salario;
            Funcao = funcao;
            BilheteModel = new List<BilheteModel>();
        }*/
    }
}
