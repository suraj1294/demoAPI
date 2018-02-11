namespace WebAPIDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUsertypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Users values('Farmer')");
            Sql("INSERT INTO Users values('Marketer')");
            Sql("INSERT INTO Users values('Society')");
            Sql("INSERT INTO Users values('Organisation')");
            Sql("INSERT INTO Users values('Agent')");
        }
        
        public override void Down()
        {
        }
    }
}
