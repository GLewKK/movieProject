namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Clasification_Changes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clasifications", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clasifications", "Description");
        }
    }
}
