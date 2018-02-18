namespace WebAPIDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNewForeignKeyState1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Countries", "Name", c => c.String());
            AlterColumn("dbo.States", "Name", c => c.String());
            AlterColumn("dbo.States", "CountryId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.States", "CountryId", c => c.String(nullable: false));
            AlterColumn("dbo.States", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Countries", "Name", c => c.String(nullable: false));
        }
    }
}
