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
    }
}
