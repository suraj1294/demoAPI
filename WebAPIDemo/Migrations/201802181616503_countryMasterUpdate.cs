namespace WebAPIDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class countryMasterUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Districts", "State_Id", "dbo.States");
            DropForeignKey("dbo.States", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.Tehsils", "District_Id", "dbo.Districts");
            DropIndex("dbo.Districts", new[] { "State_Id" });
            DropIndex("dbo.States", new[] { "Country_Id" });
            DropIndex("dbo.Tehsils", new[] { "District_Id" });
            RenameColumn(table: "dbo.Districts", name: "State_Id", newName: "StateId");
            RenameColumn(table: "dbo.States", name: "Country_Id", newName: "CountryId");
            RenameColumn(table: "dbo.Tehsils", name: "District_Id", newName: "DistrictId");
            AlterColumn("dbo.Countries", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Districts", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Districts", "StateId", c => c.Int(nullable: false));
            AlterColumn("dbo.States", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.States", "CountryId", c => c.Int(nullable: false));
            AlterColumn("dbo.Tehsils", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Tehsils", "DistrictId", c => c.Int(nullable: false));
            CreateIndex("dbo.Districts", "StateId");
            CreateIndex("dbo.States", "CountryId");
            CreateIndex("dbo.Tehsils", "DistrictId");
            AddForeignKey("dbo.Districts", "StateId", "dbo.States", "Id", cascadeDelete: true);
            AddForeignKey("dbo.States", "CountryId", "dbo.Countries", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Tehsils", "DistrictId", "dbo.Districts", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tehsils", "DistrictId", "dbo.Districts");
            DropForeignKey("dbo.States", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Districts", "StateId", "dbo.States");
            DropIndex("dbo.Tehsils", new[] { "DistrictId" });
            DropIndex("dbo.States", new[] { "CountryId" });
            DropIndex("dbo.Districts", new[] { "StateId" });
            AlterColumn("dbo.Tehsils", "DistrictId", c => c.Int());
            AlterColumn("dbo.Tehsils", "Name", c => c.String());
            AlterColumn("dbo.States", "CountryId", c => c.Int());
            AlterColumn("dbo.States", "Name", c => c.String());
            AlterColumn("dbo.Districts", "StateId", c => c.Int());
            AlterColumn("dbo.Districts", "Name", c => c.String());
            AlterColumn("dbo.Countries", "Name", c => c.String());
            RenameColumn(table: "dbo.Tehsils", name: "DistrictId", newName: "District_Id");
            RenameColumn(table: "dbo.States", name: "CountryId", newName: "Country_Id");
            RenameColumn(table: "dbo.Districts", name: "StateId", newName: "State_Id");
            CreateIndex("dbo.Tehsils", "District_Id");
            CreateIndex("dbo.States", "Country_Id");
            CreateIndex("dbo.Districts", "State_Id");
            AddForeignKey("dbo.Tehsils", "District_Id", "dbo.Districts", "Id");
            AddForeignKey("dbo.States", "Country_Id", "dbo.Countries", "Id");
            AddForeignKey("dbo.Districts", "State_Id", "dbo.States", "Id");
        }
    }
}
