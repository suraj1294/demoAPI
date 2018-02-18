namespace WebAPIDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNewForeignKeyState : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Countries");
            AddColumn("dbo.States", "CountryId", c => c.String(nullable: false));
            AddColumn("dbo.States", "Country_Id", c => c.Int());
            AlterColumn("dbo.Countries", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Countries", "Name", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Countries", "Id");
            CreateIndex("dbo.States", "Country_Id");
            AddForeignKey("dbo.States", "Country_Id", "dbo.Countries", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.States", "Country_Id", "dbo.Countries");
            DropIndex("dbo.States", new[] { "Country_Id" });
            DropPrimaryKey("dbo.Countries");
            AlterColumn("dbo.Countries", "Name", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Countries", "Id", c => c.Int(nullable: false));
            DropColumn("dbo.States", "Country_Id");
            DropColumn("dbo.States", "CountryId");
            AddPrimaryKey("dbo.Countries", new[] { "Id", "Name" });
        }
    }
}
