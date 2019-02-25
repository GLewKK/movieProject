namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImageType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MovieImages", "Image", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MovieImages", "Image");
        }
    }
}
