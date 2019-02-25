namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seat : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Seats",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Row = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                        AuditoriumId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Auditoriums", t => t.AuditoriumId, cascadeDelete: true)
                .Index(t => t.AuditoriumId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Seats", "AuditoriumId", "dbo.Auditoriums");
            DropIndex("dbo.Seats", new[] { "AuditoriumId" });
            DropTable("dbo.Seats");
        }
    }
}
