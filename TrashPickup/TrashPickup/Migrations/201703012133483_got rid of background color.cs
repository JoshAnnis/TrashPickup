namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gotridofbackgroundcolor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "AddressId", c => c.Int(nullable: false));
            CreateIndex("dbo.AspNetUsers", "AddressId");

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "AddressId", "dbo.Addresses");
            DropIndex("dbo.AspNetUsers", new[] { "AddressId" });
            DropColumn("dbo.AspNetUsers", "AddressId");
        }
    }
}
