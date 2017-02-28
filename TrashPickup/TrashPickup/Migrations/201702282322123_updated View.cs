namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedView : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "Password");
        }
    }
}
