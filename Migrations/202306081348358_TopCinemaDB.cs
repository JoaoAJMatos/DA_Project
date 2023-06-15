namespace TopCinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TopCinemaDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BilheteModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Coluna = c.Int(nullable: false),
                        Usado = c.Boolean(nullable: false),
                        SessaoModel_Id = c.Int(),
                        ClienteModel_Id = c.Int(),
                        FuncionarioModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SessaoModels", t => t.SessaoModel_Id)
                .ForeignKey("dbo.PessoaModels", t => t.ClienteModel_Id)
                .ForeignKey("dbo.PessoaModels", t => t.FuncionarioModel_Id)
                .Index(t => t.SessaoModel_Id)
                .Index(t => t.ClienteModel_Id)
                .Index(t => t.FuncionarioModel_Id);
            
            CreateTable(
                "dbo.CategoriaModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Ativa = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CinemaModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Morada = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SalaModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Colunas = c.Int(nullable: false),
                        Filas = c.Int(nullable: false),
                        CinemaModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CinemaModels", t => t.CinemaModel_Id)
                .Index(t => t.CinemaModel_Id);
            
            CreateTable(
                "dbo.SessaoModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HoraInicio = c.DateTime(nullable: false),
                        Preco = c.Single(nullable: false),
                        Filme_Id = c.Int(),
                        SalaModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FilmeModels", t => t.Filme_Id)
                .ForeignKey("dbo.SalaModels", t => t.SalaModel_Id)
                .Index(t => t.Filme_Id)
                .Index(t => t.SalaModel_Id);
            
            CreateTable(
                "dbo.FilmeModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Duracao = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        Categoria_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CategoriaModels", t => t.Categoria_Id)
                .Index(t => t.Categoria_Id);
            
            CreateTable(
                "dbo.PessoaModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Morada = c.String(),
                        Nif = c.Int(),
                        Salario = c.Single(),
                        Funcao = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BilheteModels", "FuncionarioModel_Id", "dbo.PessoaModels");
            DropForeignKey("dbo.BilheteModels", "ClienteModel_Id", "dbo.PessoaModels");
            DropForeignKey("dbo.SalaModels", "CinemaModel_Id", "dbo.CinemaModels");
            DropForeignKey("dbo.SessaoModels", "SalaModel_Id", "dbo.SalaModels");
            DropForeignKey("dbo.BilheteModels", "SessaoModel_Id", "dbo.SessaoModels");
            DropForeignKey("dbo.SessaoModels", "Filme_Id", "dbo.FilmeModels");
            DropForeignKey("dbo.FilmeModels", "Categoria_Id", "dbo.CategoriaModels");
            DropIndex("dbo.FilmeModels", new[] { "Categoria_Id" });
            DropIndex("dbo.SessaoModels", new[] { "SalaModel_Id" });
            DropIndex("dbo.SessaoModels", new[] { "Filme_Id" });
            DropIndex("dbo.SalaModels", new[] { "CinemaModel_Id" });
            DropIndex("dbo.BilheteModels", new[] { "FuncionarioModel_Id" });
            DropIndex("dbo.BilheteModels", new[] { "ClienteModel_Id" });
            DropIndex("dbo.BilheteModels", new[] { "SessaoModel_Id" });
            DropTable("dbo.PessoaModels");
            DropTable("dbo.FilmeModels");
            DropTable("dbo.SessaoModels");
            DropTable("dbo.SalaModels");
            DropTable("dbo.CinemaModels");
            DropTable("dbo.CategoriaModels");
            DropTable("dbo.BilheteModels");
        }
    }
}
