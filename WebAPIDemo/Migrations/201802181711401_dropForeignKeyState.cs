namespace WebAPIDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropForeignKeyState : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.States", "Name", "dbo.Countries");
        }
        
        public override void Down()
        {
        }
    }
}
