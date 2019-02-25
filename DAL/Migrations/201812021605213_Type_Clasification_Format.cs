namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Type_Clasification_Format : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clasifications",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MovieFormats",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FormatType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MovieTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MovieTypes");
            DropTable("dbo.MovieFormats");
            DropTable("dbo.Clasifications");
        }
    }
}
