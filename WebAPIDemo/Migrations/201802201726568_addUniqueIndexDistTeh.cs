namespace WebAPIDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUniqueIndexDistTeh : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Districts", new[] { "StateId" });
            DropIndex("dbo.Tehsils", new[] { "DistrictId" });
            AlterColumn("dbo.Districts", "Name", c => c.String(nullable: false, maxLength: 480));
            AlterColumn("dbo.Tehsils", "Name", c => c.String(nullable: false, maxLength: 480));
            CreateIndex("dbo.Districts", "Name", unique: true);            
            CreateIndex("dbo.Tehsils", "Name", unique: true);            
        }
        
        public override void Down()
        {
            
            DropIndex("dbo.Tehsils", new[] { "Name" });            
            DropIndex("dbo.Districts", new[] { "Name" });
            AlterColumn("dbo.Tehsils", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Districts", "Name", c => c.String(nullable: false));
            CreateIndex("dbo.Tehsils", "DistrictId");
            CreateIndex("dbo.Districts", "StateId");
        }
    }
}
