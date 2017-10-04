namespace _14DTHC1_2.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class populateCategoryDataSample : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Categories (Id, Name) values(1,'Development')");
            Sql("Insert into Categories (Id, Name) values(2,'Marketing online')");
            Sql("Insert into Categories (Id, Name) values(3,'Design')");
        }

        public override void Down()
        {
        }
    }
}
