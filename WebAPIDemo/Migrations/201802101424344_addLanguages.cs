namespace WebAPIDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addLanguages : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Languages values('Marathi')");
            Sql("INSERT INTO Languages values('English')");
            Sql("INSERT INTO Languages values('Hindi')");
        }
        
        public override void Down()
        {
        }
    }
}
