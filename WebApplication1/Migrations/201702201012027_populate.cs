namespace WebApplication1.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class populate : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Leagues(ID,name)VALUES (1,'EPL')");
            Sql("INSERT INTO Leagues(ID,name)VALUES (2,'Serie A')");
            Sql("INSERT INTO Leagues(ID,name)VALUES (3,'La Liga')");
            Sql("INSERT INTO Leagues(ID,name)VALUES (4,'Bundesliga')");

        }
        
        public override void Down()
        {
            Sql("DELETE FROM LEAGUES WHERE ID in (1,2,3,4)");
        }
    }
}
