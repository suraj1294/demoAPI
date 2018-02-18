namespace WebAPIDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNewForeignKeyState2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.States", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.Districts", "StateId", "dbo.States");
            DropForeignKey("dbo.Tehsils", "DistrictId", "dbo.Districts");
            DropIndex("dbo.Districts", new[] { "StateId" });
            DropIndex("dbo.States", new[] { "Country_Id" });
            DropIndex("dbo.Tehsils", new[] { "DistrictId" });
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
                        Name = c.String(),
                        CountryId = c.String(),
                        Country_Id = c.Int(),
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
            
            CreateIndex("dbo.Tehsils", "DistrictId");
            CreateIndex("dbo.States", "Country_Id");
            CreateIndex("dbo.Districts", "StateId");
            AddForeignKey("dbo.Tehsils", "DistrictId", "dbo.Districts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Districts", "StateId", "dbo.States", "Id", cascadeDelete: true);
            AddForeignKey("dbo.States", "Country_Id", "dbo.Countries", "Id");
        }
    }
}
