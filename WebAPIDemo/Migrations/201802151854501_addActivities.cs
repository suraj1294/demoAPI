namespace WebAPIDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addActivities : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Activities values ('Agro-Chemical')");
            Sql("INSERT INTO Activities values ('Basal Fertilizer')");
            Sql("INSERT INTO Activities values ('Bed Preparation')");
            Sql("INSERT INTO Activities values ('Building Construction')");
            Sql("INSERT INTO Activities values ('Bund Making')");
            Sql("INSERT INTO Activities values ('Collar Forking')");
            Sql("INSERT INTO Activities values ('Crown Cleaning')");
            Sql("INSERT INTO Activities values ('Cutting And Charging')");
            Sql("INSERT INTO Activities values ('Drenching')");
            Sql("INSERT INTO Activities values ('Drip Installation')");
            Sql("INSERT INTO Activities values ('Earthing Up')");
            Sql("INSERT INTO Activities values ('Fencing')");
            Sql("INSERT INTO Activities values ('Fencing Maintenance')");
            Sql("INSERT INTO Activities values ('Fertigation')");
            Sql("INSERT INTO Activities values ('Fertilizer')");
            Sql("INSERT INTO Activities values ('Quality Check')");
            Sql("INSERT INTO Activities values ('Grading And Sorting')");
            Sql("INSERT INTO Activities values ('Harvesting')");
            Sql("INSERT INTO Activities values ('Irrigation')");
            Sql("INSERT INTO Activities values ('Lateral Maintenance')");
            Sql("INSERT INTO Activities values ('Mortality')");
            Sql("INSERT INTO Activities values ('Mulch Spreading')");
            Sql("INSERT INTO Activities values ('Observation')");
            Sql("INSERT INTO Activities values ('Pinching')");
            Sql("INSERT INTO Activities values ('Pit Digging')");
            Sql("INSERT INTO Activities values ('Pit Filling')");
            Sql("INSERT INTO Activities values ('Planting')");
            Sql("INSERT INTO Activities values ('Pruning')");
            Sql("INSERT INTO Activities values ('Replanting')");
            Sql("INSERT INTO Activities values ('Sampling')");
            Sql("INSERT INTO Activities values ('Shifting')");
            Sql("INSERT INTO Activities values ('Smooth Sheeting')");
            Sql("INSERT INTO Activities values ('Sorting And Grading')");
            Sql("INSERT INTO Activities values ('Sowing')");
            Sql("INSERT INTO Activities values ('Stacking')");
            Sql("INSERT INTO Activities values ('Sucker Removal')");
            Sql("INSERT INTO Activities values ('Training')");
            Sql("INSERT INTO Activities values ('Transfer')");
            Sql("INSERT INTO Activities values ('Transplanting')");
            Sql("INSERT INTO Activities values ('Vermicompost')");
            Sql("INSERT INTO Activities values ('Weeding')");
            Sql("INSERT INTO Activities values ('Yield Estimation')");
        }
        
        public override void Down()
        {
        }
    }
}
