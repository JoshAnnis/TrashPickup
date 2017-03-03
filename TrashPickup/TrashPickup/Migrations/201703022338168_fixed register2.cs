namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedregister2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Addresses", "address_Id", "dbo.Addresses");
            DropIndex("dbo.Addresses", new[] { "address_Id" });
            AddColumn("dbo.Addresses", "street", c => c.String());
            DropColumn("dbo.Addresses", "address_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Addresses", "address_Id", c => c.Int());
            DropColumn("dbo.Addresses", "street");
            CreateIndex("dbo.Addresses", "address_Id");
            AddForeignKey("dbo.Addresses", "address_Id", "dbo.Addresses", "Id");
        }
    }
}
