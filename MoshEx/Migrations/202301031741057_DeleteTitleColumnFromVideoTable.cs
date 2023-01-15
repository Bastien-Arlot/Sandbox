namespace MoshEx.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class DeleteTitleColumnFromVideoTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Videos", "Title");
        }

        public override void Down()
        {
            AddColumn("dbo.Videos", "Title", c => c.String());
        }
    }
}
