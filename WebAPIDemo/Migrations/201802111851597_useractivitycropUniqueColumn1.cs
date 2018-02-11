namespace WebAPIDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class useractivitycropUniqueColumn1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.UserActivities");
            DropPrimaryKey("dbo.UserCrops");
            AddPrimaryKey("dbo.UserActivities", new[] { "ApplicationUserId", "Name" });
            AddPrimaryKey("dbo.UserCrops", new[] { "ApplicationUserId", "Name" });
            DropColumn("dbo.UserActivities", "Id");
            DropColumn("dbo.UserCrops", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserCrops", "Id", c => c.Int(nullable: false));
            AddColumn("dbo.UserActivities", "Id", c => c.Int(nullable: false));
            DropPrimaryKey("dbo.UserCrops");
            DropPrimaryKey("dbo.UserActivities");
            AddPrimaryKey("dbo.UserCrops", new[] { "Id", "ApplicationUserId", "Name" });
            AddPrimaryKey("dbo.UserActivities", new[] { "Id", "ApplicationUserId", "Name" });
        }
    }
}
