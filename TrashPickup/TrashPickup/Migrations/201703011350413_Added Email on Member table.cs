namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedEmailonMembertable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Zips", "Zipcode", c => c.String());
            AddColumn("dbo.Members", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "Email");
            DropColumn("dbo.Zips", "Zipcode");
        }
    }
}
