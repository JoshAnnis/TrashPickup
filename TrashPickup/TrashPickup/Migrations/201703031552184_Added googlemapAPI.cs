namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedgooglemapAPI : DbMigration
    {
        public override void Up()
        {
            
            DropColumn("dbo.AspNetUsers", "Last_Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Last_Name", c => c.String());
           
        }
    }
}
