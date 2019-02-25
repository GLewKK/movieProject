namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieTypeRemoved : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "MovieTypeId", "dbo.MovieTypes");
            DropIndex("dbo.Movies", new[] { "MovieTypeId" });
            DropColumn("dbo.Movies", "MovieTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "MovieTypeId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Movies", "MovieTypeId");
            AddForeignKey("dbo.Movies", "MovieTypeId", "dbo.MovieTypes", "Id", cascadeDelete: true);
        }
    }
}
