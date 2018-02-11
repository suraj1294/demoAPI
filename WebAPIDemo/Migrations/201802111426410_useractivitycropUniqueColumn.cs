namespace WebAPIDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class useractivitycropUniqueColumn : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserActivities",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        ApplicationUserId = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Id, t.ApplicationUserId, t.Name })
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId, cascadeDelete: true)
                .Index(t => t.ApplicationUserId);
            
            CreateTable(
                "dbo.UserCrops",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        ApplicationUserId = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Id, t.ApplicationUserId, t.Name })
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId, cascadeDelete: true)
                .Index(t => t.ApplicationUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserCrops", "ApplicationUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserActivities", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.UserCrops", new[] { "ApplicationUserId" });
            DropIndex("dbo.UserActivities", new[] { "ApplicationUserId" });
            DropTable("dbo.UserCrops");
            DropTable("dbo.UserActivities");
        }
    }
}
