namespace WebAPIDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUniqueIndexState : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.States", new[] { "CountryId" });
            AlterColumn("dbo.States", "Name", c => c.String(nullable: false, maxLength: 480));
            CreateIndex("dbo.States", "Name", unique: true);
            CreateIndex("dbo.States", "CountryId", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.States", new[] { "CountryId" });
            DropIndex("dbo.States", new[] { "Name" });
            AlterColumn("dbo.States", "Name", c => c.String(nullable: false));
            CreateIndex("dbo.States", "CountryId");
        }
    }
}
