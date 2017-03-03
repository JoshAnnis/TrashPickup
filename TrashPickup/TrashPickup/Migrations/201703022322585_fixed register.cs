namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedregister : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Zips", "Zipcode", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Zips", "Zipcode", c => c.String());
        }
    }
}
