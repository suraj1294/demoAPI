namespace WebAPIDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateProfile : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.PersonalProfiles");
            AddPrimaryKey("dbo.PersonalProfiles", new[] { "Id", "UserName" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.PersonalProfiles");
            AddPrimaryKey("dbo.PersonalProfiles", "UserName");
        }
    }
}
