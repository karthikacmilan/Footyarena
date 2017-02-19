namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createMatchTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Leagues",
                c => new
                    {
                        ID = c.Byte(nullable: false),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        venue = c.String(),
                        League_ID = c.Byte(),
                        Team_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Leagues", t => t.League_ID)
                .ForeignKey("dbo.AspNetUsers", t => t.Team_Id)
                .Index(t => t.League_ID)
                .Index(t => t.Team_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matches", "Team_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Matches", "League_ID", "dbo.Leagues");
            DropIndex("dbo.Matches", new[] { "Team_Id" });
            DropIndex("dbo.Matches", new[] { "League_ID" });
            DropTable("dbo.Matches");
            DropTable("dbo.Leagues");
        }
    }
}
