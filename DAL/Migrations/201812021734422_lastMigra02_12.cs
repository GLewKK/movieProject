namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lastMigra02_12 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MovieImageId = c.Guid(nullable: false),
                        Name = c.String(),
                        TrailerLink = c.String(),
                        PremiereDate = c.DateTime(nullable: false),
                        MovieFormatId = c.Guid(nullable: false),
                        MovieTypeId = c.Guid(nullable: false),
                        Lenght = c.Int(nullable: false),
                        ClasificationId = c.Guid(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clasifications", t => t.ClasificationId, cascadeDelete: true)
                .ForeignKey("dbo.MovieFormats", t => t.MovieFormatId, cascadeDelete: true)
                .ForeignKey("dbo.MovieImages", t => t.MovieImageId, cascadeDelete: true)
                .ForeignKey("dbo.MovieTypes", t => t.MovieTypeId, cascadeDelete: true)
                .Index(t => t.MovieImageId)
                .Index(t => t.MovieFormatId)
                .Index(t => t.MovieTypeId)
                .Index(t => t.ClasificationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "MovieTypeId", "dbo.MovieTypes");
            DropForeignKey("dbo.Movies", "MovieImageId", "dbo.MovieImages");
            DropForeignKey("dbo.Movies", "MovieFormatId", "dbo.MovieFormats");
            DropForeignKey("dbo.Movies", "ClasificationId", "dbo.Clasifications");
            DropIndex("dbo.Movies", new[] { "ClasificationId" });
            DropIndex("dbo.Movies", new[] { "MovieTypeId" });
            DropIndex("dbo.Movies", new[] { "MovieFormatId" });
            DropIndex("dbo.Movies", new[] { "MovieImageId" });
            DropTable("dbo.Movies");
        }
    }
}
