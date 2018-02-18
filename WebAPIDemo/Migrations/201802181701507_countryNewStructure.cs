namespace WebAPIDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class countryNewStructure : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        StateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.States", t => t.StateId, cascadeDelete: true)
                .Index(t => t.StateId);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 128),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => new { t.Id, t.Name }, cascadeDelete: true)
                .Index(t => new { t.Id, t.Name });
            
            CreateTable(
                "dbo.Tehsils",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        DistrictId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Districts", t => t.DistrictId, cascadeDelete: true)
                .Index(t => t.DistrictId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tehsils", "DistrictId", "dbo.Districts");
            DropForeignKey("dbo.Districts", "StateId", "dbo.States");
            DropForeignKey("dbo.States", new[] { "Id", "Name" }, "dbo.Countries");
            DropIndex("dbo.Tehsils", new[] { "DistrictId" });
            DropIndex("dbo.States", new[] { "Id", "Name" });
            DropIndex("dbo.Districts", new[] { "StateId" });
            DropTable("dbo.Tehsils");
            DropTable("dbo.States");
            DropTable("dbo.Districts");
        }
    }
}
