using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCinema.Models
{
    internal class ClienteModel : PessoaModel
    {
        public int NumFiscal { get; set; }
        public List<BilheteModel> BilheteModel { get; set; }

        public ClienteModel(string name,string morada,int numFiscal) : base(name, morada)
        {
            NumFiscal = numFiscal;
            BilheteModel = new List<BilheteModel>();
        }
        public ClienteModel() : base("","")
        {
            
        }

        public override string ToString()
        {
            string original = base.ToString();
            original += NumFiscal + "\n";
            return original;
        }
    }
}
