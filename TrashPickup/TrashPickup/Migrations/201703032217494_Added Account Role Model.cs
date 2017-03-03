namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAccountRoleModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "AccountRoleId", c => c.Int(nullable: false));
            CreateIndex("dbo.AspNetUsers", "AccountRoleId");
            AddForeignKey("dbo.AspNetUsers", "AccountRoleId", "dbo.AccountRoles", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "AccountRoleId", "dbo.AccountRoles");
            DropIndex("dbo.AspNetUsers", new[] { "AccountRoleId" });
            DropColumn("dbo.AspNetUsers", "AccountRoleId");
            DropTable("dbo.AccountRoles");
        }
    }
}
