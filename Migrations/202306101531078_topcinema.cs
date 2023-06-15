namespace TopCinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class topcinema : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BilheteModels", "Fila", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BilheteModels", "Fila");
        }
    }
}
