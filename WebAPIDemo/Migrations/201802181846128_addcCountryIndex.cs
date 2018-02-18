namespace WebAPIDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcCountryIndex : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Countries", "Name", c => c.String(maxLength: 450));
            CreateIndex("dbo.Countries", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Countries", new[] { "Name" });
            AlterColumn("dbo.Countries", "Name", c => c.String());
        }
    }
}
