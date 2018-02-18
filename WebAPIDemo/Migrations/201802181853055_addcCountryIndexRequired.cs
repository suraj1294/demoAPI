namespace WebAPIDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcCountryIndexRequired : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Countries", new[] { "Name" });
            AlterColumn("dbo.Countries", "Name", c => c.String(nullable: false, maxLength: 450));
            CreateIndex("dbo.Countries", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Countries", new[] { "Name" });
            AlterColumn("dbo.Countries", "Name", c => c.String(maxLength: 450));
            CreateIndex("dbo.Countries", "Name", unique: true);
        }
    }
}
