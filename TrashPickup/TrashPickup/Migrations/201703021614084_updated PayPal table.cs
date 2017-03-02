namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedPayPaltable : DbMigration
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PayPals");
        }
    }
}
