namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class menu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addresses", "address_Id", c => c.Int());
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            CreateIndex("dbo.Addresses", "address_Id");
            AddForeignKey("dbo.Addresses", "address_Id", "dbo.Addresses", "Id");
            DropColumn("dbo.Addresses", "address");
            DropColumn("dbo.AspNetUsers", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Name", c => c.String());
            AddColumn("dbo.Addresses", "address", c => c.String());
            DropForeignKey("dbo.Addresses", "address_Id", "dbo.Addresses");
            DropIndex("dbo.Addresses", new[] { "address_Id" });
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropColumn("dbo.Addresses", "address_Id");
        }
    }
}
