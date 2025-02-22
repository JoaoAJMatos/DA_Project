﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCinema.Models
{
    internal class CinemaModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Morada { get; set; }
        public string Email { get; set; }
        public List<SalaModel> ListaSalas { get; set; }

        public CinemaModel() { }

        public CinemaModel(string name, string morada, string email) 
        {
            Name = name;
            Morada = morada;
            Email = email;
            ListaSalas = new List<SalaModel>();    
        }
    }
}
