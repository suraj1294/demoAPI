namespace WebAPIDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateProfile1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.PersonalProfiles");
            AddColumn("dbo.PersonalProfiles", "ApplicationUserId", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.PersonalProfiles", "UserName");
            CreateIndex("dbo.PersonalProfiles", "ApplicationUserId");
            AddForeignKey("dbo.PersonalProfiles", "ApplicationUserId", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.PersonalProfiles", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PersonalProfiles", "Id", c => c.Int(nullable: false));
            DropForeignKey("dbo.PersonalProfiles", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.PersonalProfiles", new[] { "ApplicationUserId" });
            DropPrimaryKey("dbo.PersonalProfiles");
            DropColumn("dbo.PersonalProfiles", "ApplicationUserId");
            AddPrimaryKey("dbo.PersonalProfiles", new[] { "Id", "UserName" });
        }
    }
}
