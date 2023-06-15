namespace TopCinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class topcinemadb2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BilheteModels", "LugarStr", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BilheteModels", "LugarStr");
        }
    }
}
