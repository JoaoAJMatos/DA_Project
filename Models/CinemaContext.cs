using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TopCinema.Models
{
    internal class CinemaContext : DbContext
    {
        public DbSet<BilheteModel> Bilhetes {get;set; }
        public DbSet<CategoriaModel> Categorias { get;set; }
        public DbSet<CinemaModel> Cinemas { get;set;}
        public DbSet<FilmeModel> Filmes { get;set; }
        public DbSet<FuncionarioModel> Funcionarios { get;set;}
        public DbSet<PessoaModel> Pessoas { get;set;}
        public DbSet<SalaModel> Salas { get;set; }
        public DbSet<SessaoModel> Sessaos { get;set;}
        public DbSet<ClienteModel> Clientes { get; set; }
    }
}
