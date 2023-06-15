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
        public DbSet<SessaoModel> Sessoes { get;set;}
        public DbSet<ClienteModel> Clientes { get; set; }

        public CinemaContext() : base("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TopCinemaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            Database.SetInitializer<CinemaContext>(new CreateDatabaseIfNotExists<CinemaContext>());
        }
    }
}
