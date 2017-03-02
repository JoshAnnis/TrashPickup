namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Madedropdown : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PayPals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Name");
            DropTable("dbo.PayPals");
        }
    }
}
