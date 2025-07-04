namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabaseSchema : DbMigration
    {
        public override void Up()
        {/*
            CreateTable(
                "dbo.ProductionOrders",
                c => new
                    {
                        ProductionOrderId = c.Int(nullable: false, identity: true),
                        ProductionPlanId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        ProductCode = c.String(),
                        ProductDefinition = c.String(),
                        Quantity = c.Int(nullable: false),
                        ProductionDate = c.DateTime(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.ProductionOrderId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            */
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductionOrders", "ProductId", "dbo.Products");
            DropIndex("dbo.ProductionOrders", new[] { "ProductId" });
            DropTable("dbo.ProductionOrders");
        }
    }
}
