namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixeddboAspNetUsers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addresses", "address_Id", c => c.Int());
            AddColumn("dbo.AspNetUsers", "Last_Name", c => c.String());
            CreateIndex("dbo.Addresses", "address_Id");
            AddForeignKey("dbo.Addresses", "address_Id", "dbo.Addresses", "Id");
            DropColumn("dbo.Addresses", "address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Addresses", "address", c => c.String());
            DropForeignKey("dbo.Addresses", "address_Id", "dbo.Addresses");
            DropIndex("dbo.Addresses", new[] { "address_Id" });
            DropColumn("dbo.AspNetUsers", "Last_Name");
            DropColumn("dbo.Addresses", "address_Id");
        }
    }
}
