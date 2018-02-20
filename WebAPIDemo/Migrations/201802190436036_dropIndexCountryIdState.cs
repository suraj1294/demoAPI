namespace WebAPIDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropIndexCountryIdState : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.States", new[] { "CountryId" });
        }
        
        public override void Down()
        {
        }
    }
}
