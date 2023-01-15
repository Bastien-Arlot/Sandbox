namespace MoshEx.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddData2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres  VALUES ('Horror')");
            Sql("INSERT INTO Genres  VALUES ('Comedy')");
        }

        public override void Down()
        {
        }
    }
}
