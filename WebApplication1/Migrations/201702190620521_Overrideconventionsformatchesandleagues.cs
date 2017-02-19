namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Overrideconventionsformatchesandleagues : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Matches", "League_ID", "dbo.Leagues");
            DropForeignKey("dbo.Matches", "Team_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Matches", new[] { "League_ID" });
            DropIndex("dbo.Matches", new[] { "Team_Id" });
            AlterColumn("dbo.Leagues", "name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Matches", "venue", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Matches", "League_ID", c => c.Byte(nullable: false));
            AlterColumn("dbo.Matches", "Team_Id", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Matches", "League_ID");
            CreateIndex("dbo.Matches", "Team_Id");
            AddForeignKey("dbo.Matches", "League_ID", "dbo.Leagues", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Matches", "Team_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matches", "Team_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Matches", "League_ID", "dbo.Leagues");
            DropIndex("dbo.Matches", new[] { "Team_Id" });
            DropIndex("dbo.Matches", new[] { "League_ID" });
            AlterColumn("dbo.Matches", "Team_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Matches", "League_ID", c => c.Byte());
            AlterColumn("dbo.Matches", "venue", c => c.String());
            AlterColumn("dbo.Leagues", "name", c => c.String());
            CreateIndex("dbo.Matches", "Team_Id");
            CreateIndex("dbo.Matches", "League_ID");
            AddForeignKey("dbo.Matches", "Team_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Matches", "League_ID", "dbo.Leagues", "ID");
        }
    }
}
