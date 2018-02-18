namespace WebAPIDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class countryIndexUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.States", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Districts", "StateId", "dbo.States");
            DropForeignKey("dbo.Tehsils", "DistrictId", "dbo.Districts");
            DropIndex("dbo.Districts", new[] { "StateId" });
            DropIndex("dbo.States", new[] { "CountryId" });
            DropIndex("dbo.Tehsils", new[] { "DistrictId" });
            DropPrimaryKey("dbo.Countries");
            AlterColumn("dbo.Countries", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Countries", "Name", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Countries", new[] { "Id", "Name" });
            DropTable("dbo.Districts");
            DropTable("dbo.States");
            DropTable("dbo.Tehsils");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Tehsils",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        DistrictId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        StateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropPrimaryKey("dbo.Countries");
            AlterColumn("dbo.Countries", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Countries", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Countries", "Id");
            CreateIndex("dbo.Tehsils", "DistrictId");
            CreateIndex("dbo.States", "CountryId");
            CreateIndex("dbo.Districts", "StateId");
            AddForeignKey("dbo.Tehsils", "DistrictId", "dbo.Districts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Districts", "StateId", "dbo.States", "Id", cascadeDelete: true);
            AddForeignKey("dbo.States", "CountryId", "dbo.Countries", "Id", cascadeDelete: true);
        }
    }
}
