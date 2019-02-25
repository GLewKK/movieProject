namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Auditorium_Image : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Auditoriums",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        SeatsNr = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MovieImages",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ImgName = c.String(),
                        ImgPath = c.String(),
                        Width = c.Int(nullable: false),
                        Lenght = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MovieImages");
            DropTable("dbo.Auditoriums");
        }
    }
}
