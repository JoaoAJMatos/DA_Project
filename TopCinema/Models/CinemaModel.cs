using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCinema.Models
{
    internal class CinemaModel
    {
        public string Name { get; set; }
        public string Morada { get; set; }
        public string Email { get; set; }
        public List<SalaModel> SalaModel { get; set; }


        public CinemaModel(string name,string morada,string email) {
            Name = name;
            Morada = morada;
            Email = email;
            SalaModel = new List<SalaModel>();
            
        }
    }
}
