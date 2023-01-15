namespace MoshEx.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddData1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('Horror')");
            Sql("INSERT INTO Genres (Name) VALUES ('Comedy')");

        }

        public override void Down()
        {
        }
    }
}
