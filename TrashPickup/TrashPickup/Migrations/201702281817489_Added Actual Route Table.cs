namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedActualRouteTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Routes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ZipRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Zips", t => t.ZipRefId, cascadeDelete: true)
                .Index(t => t.ZipRefId);
            
            CreateTable(
                "dbo.Zips",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Routes", "ZipRefId", "dbo.Zips");
            DropIndex("dbo.Routes", new[] { "ZipRefId" });
            DropTable("dbo.Zips");
            DropTable("dbo.Routes");
        }
    }
}
