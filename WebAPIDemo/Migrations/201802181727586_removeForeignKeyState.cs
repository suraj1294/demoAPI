namespace WebAPIDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeForeignKeyState : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.States", new[] { "Id", "Name" }, "dbo.Countries");
            DropForeignKey("dbo.Districts", "StateId", "dbo.States");
            DropIndex("dbo.States", new[] { "Id", "Name" });
            DropPrimaryKey("dbo.States");
            AlterColumn("dbo.States", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.States", "Name", c => c.String(nullable: false));
            AddPrimaryKey("dbo.States", "Id");
            AddForeignKey("dbo.Districts", "StateId", "dbo.States", "Id", cascadeDelete: true);
            DropColumn("dbo.States", "CountryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.States", "CountryId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Districts", "StateId", "dbo.States");
            DropPrimaryKey("dbo.States");
            AlterColumn("dbo.States", "Name", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.States", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.States", "Id");
            CreateIndex("dbo.States", new[] { "Id", "Name" });
            AddForeignKey("dbo.Districts", "StateId", "dbo.States", "Id", cascadeDelete: true);
            AddForeignKey("dbo.States", new[] { "Id", "Name" }, "dbo.Countries", new[] { "Id", "Name" }, cascadeDelete: true);
        }
    }
}
