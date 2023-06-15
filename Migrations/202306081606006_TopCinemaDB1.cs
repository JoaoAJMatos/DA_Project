namespace TopCinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TopCinemaDB1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.SessaoModels", name: "SalaModel_Id", newName: "Sala_Id");
            RenameIndex(table: "dbo.SessaoModels", name: "IX_SalaModel_Id", newName: "IX_Sala_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.SessaoModels", name: "IX_Sala_Id", newName: "IX_SalaModel_Id");
            RenameColumn(table: "dbo.SessaoModels", name: "Sala_Id", newName: "SalaModel_Id");
        }
    }
}
