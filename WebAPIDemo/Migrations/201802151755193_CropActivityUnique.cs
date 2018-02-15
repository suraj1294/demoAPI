namespace WebAPIDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CropActivityUnique : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Activities");
            DropPrimaryKey("dbo.Crops");
            AlterColumn("dbo.Activities", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Activities", "Name", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Crops", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Crops", "NameE", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Crops", "NameH", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Activities", new[] { "Id", "Name" });
            AddPrimaryKey("dbo.Crops", new[] { "Id", "NameE", "NameH" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Crops");
            DropPrimaryKey("dbo.Activities");
            AlterColumn("dbo.Crops", "NameH", c => c.String());
            AlterColumn("dbo.Crops", "NameE", c => c.String());
            AlterColumn("dbo.Crops", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Activities", "Name", c => c.String());
            AlterColumn("dbo.Activities", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Crops", "Id");
            AddPrimaryKey("dbo.Activities", "Id");
        }
    }
}
