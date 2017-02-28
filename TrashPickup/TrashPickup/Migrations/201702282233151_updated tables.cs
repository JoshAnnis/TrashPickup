namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedtables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        address = c.String(),
                        StateId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                        ZipId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.States", t => t.StateId, cascadeDelete: true)
                .ForeignKey("dbo.Zips", t => t.ZipId, cascadeDelete: true)
                .Index(t => t.StateId)
                .Index(t => t.CityId)
                .Index(t => t.ZipId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Zips",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CardNumber = c.Int(nullable: false),
                        CardName = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Routes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ZipId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Zips", t => t.ZipId, cascadeDelete: true)
                .Index(t => t.ZipId);
            
            AlterColumn("dbo.Workers", "Route", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Routes", "ZipId", "dbo.Zips");
            DropForeignKey("dbo.Addresses", "ZipId", "dbo.Zips");
            DropForeignKey("dbo.Addresses", "StateId", "dbo.States");
            DropForeignKey("dbo.Addresses", "CityId", "dbo.Cities");
            DropIndex("dbo.Routes", new[] { "ZipId" });
            DropIndex("dbo.Addresses", new[] { "ZipId" });
            DropIndex("dbo.Addresses", new[] { "CityId" });
            DropIndex("dbo.Addresses", new[] { "StateId" });
            AlterColumn("dbo.Workers", "Route", c => c.String());
            DropTable("dbo.Routes");
            DropTable("dbo.Payments");
            DropTable("dbo.Zips");
            DropTable("dbo.States");
            DropTable("dbo.Cities");
            DropTable("dbo.Addresses");
        }
    }
}
