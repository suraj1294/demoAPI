namespace WebAPIDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addForeignKeyState : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Districts", "StateId", "dbo.States");
            DropPrimaryKey("dbo.States");
            AddColumn("dbo.States", "CountryId", c => c.Int(nullable: false));
            AlterColumn("dbo.States", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.States", "Name", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.States", "Id");
            CreateIndex("dbo.States", new[] { "Id", "Name" });
            AddForeignKey("dbo.States", new[] { "Id", "Name" }, "dbo.Countries", new[] { "Id", "Name" }, cascadeDelete: true);
            AddForeignKey("dbo.Districts", "StateId", "dbo.States", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Districts", "StateId", "dbo.States");
            DropForeignKey("dbo.States", new[] { "Id", "Name" }, "dbo.Countries");
            DropIndex("dbo.States", new[] { "Id", "Name" });
            DropPrimaryKey("dbo.States");
            AlterColumn("dbo.States", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.States", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.States", "CountryId");
            AddPrimaryKey("dbo.States", "Id");
            AddForeignKey("dbo.Districts", "StateId", "dbo.States", "Id", cascadeDelete: true);
        }
    }
}
