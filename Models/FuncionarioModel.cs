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

        public FuncionarioModel(string name,string morada,float salario,string funcao) : base(name, morada)
        {
            Salario = salario;
            Funcao = funcao;
            BilheteModel = new List<BilheteModel>();
        }
        public FuncionarioModel() : base("", "")
        {

        }
        public override string ToString()
        {
            string original = base.ToString();
            original += Salario + "\n" + Funcao + "\n";
            return original;
        }
    }
}
