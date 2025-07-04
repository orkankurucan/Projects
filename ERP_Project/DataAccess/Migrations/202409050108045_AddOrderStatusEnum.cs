namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrderStatusEnum : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MachineAllocations", "ProductionPlanId", "dbo.ProductionPlans");
            DropIndex("dbo.MachineAllocations", new[] { "ProductionPlanId" });
            AddColumn("dbo.MachineAllocations", "ProductionPlan_ProductionPlanId", c => c.Int());
            AddColumn("dbo.MachineAllocations", "ProductionPlan_ProductionPlanId1", c => c.Int());
            AddColumn("dbo.ProductionPlans", "Component_ComponentId", c => c.Int());
            AddColumn("dbo.ProductionPlans", "Inventory_InventoryId", c => c.Int());
            AddColumn("dbo.ProductionPlans", "MachineAllocation_MachineAllocationId", c => c.Int());
            AddColumn("dbo.ProductionPlans", "Order_OrderId", c => c.Int());
            AddColumn("dbo.ProductionPlans", "OrderDetail_OrderDetailId", c => c.Int());
            AddColumn("dbo.ProductionPlans", "ProductComponent_ProductComponentId", c => c.Int());
            AlterColumn("dbo.Components", "MinimumOrderQuantity", c => c.Int(nullable: false));
            AlterColumn("dbo.PurchaseOrders", "Status", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "OrderStatus", c => c.Int(nullable: false));
            CreateIndex("dbo.MachineAllocations", "ProductionPlan_ProductionPlanId");
            CreateIndex("dbo.MachineAllocations", "ProductionPlan_ProductionPlanId1");
            CreateIndex("dbo.ProductionPlans", "Component_ComponentId");
            CreateIndex("dbo.ProductionPlans", "Inventory_InventoryId");
            CreateIndex("dbo.ProductionPlans", "MachineAllocation_MachineAllocationId");
            CreateIndex("dbo.ProductionPlans", "Order_OrderId");
            CreateIndex("dbo.ProductionPlans", "OrderDetail_OrderDetailId");
            CreateIndex("dbo.ProductionPlans", "ProductComponent_ProductComponentId");
            AddForeignKey("dbo.ProductionPlans", "Component_ComponentId", "dbo.Components", "ComponentId");
            AddForeignKey("dbo.ProductionPlans", "Inventory_InventoryId", "dbo.Inventories", "InventoryId");
            AddForeignKey("dbo.ProductionPlans", "MachineAllocation_MachineAllocationId", "dbo.MachineAllocations", "MachineAllocationId");
            AddForeignKey("dbo.ProductionPlans", "Order_OrderId", "dbo.Orders", "OrderId");
            AddForeignKey("dbo.ProductionPlans", "OrderDetail_OrderDetailId", "dbo.OrderDetails", "OrderDetailId");
            AddForeignKey("dbo.ProductionPlans", "ProductComponent_ProductComponentId", "dbo.ProductComponents", "ProductComponentId");
            AddForeignKey("dbo.MachineAllocations", "ProductionPlan_ProductionPlanId1", "dbo.ProductionPlans", "ProductionPlanId");
            AddForeignKey("dbo.MachineAllocations", "ProductionPlan_ProductionPlanId", "dbo.ProductionPlans", "ProductionPlanId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MachineAllocations", "ProductionPlan_ProductionPlanId", "dbo.ProductionPlans");
            DropForeignKey("dbo.MachineAllocations", "ProductionPlan_ProductionPlanId1", "dbo.ProductionPlans");
            DropForeignKey("dbo.ProductionPlans", "ProductComponent_ProductComponentId", "dbo.ProductComponents");
            DropForeignKey("dbo.ProductionPlans", "OrderDetail_OrderDetailId", "dbo.OrderDetails");
            DropForeignKey("dbo.ProductionPlans", "Order_OrderId", "dbo.Orders");
            DropForeignKey("dbo.ProductionPlans", "MachineAllocation_MachineAllocationId", "dbo.MachineAllocations");
            DropForeignKey("dbo.ProductionPlans", "Inventory_InventoryId", "dbo.Inventories");
            DropForeignKey("dbo.ProductionPlans", "Component_ComponentId", "dbo.Components");
            DropIndex("dbo.ProductionPlans", new[] { "ProductComponent_ProductComponentId" });
            DropIndex("dbo.ProductionPlans", new[] { "OrderDetail_OrderDetailId" });
            DropIndex("dbo.ProductionPlans", new[] { "Order_OrderId" });
            DropIndex("dbo.ProductionPlans", new[] { "MachineAllocation_MachineAllocationId" });
            DropIndex("dbo.ProductionPlans", new[] { "Inventory_InventoryId" });
            DropIndex("dbo.ProductionPlans", new[] { "Component_ComponentId" });
            DropIndex("dbo.MachineAllocations", new[] { "ProductionPlan_ProductionPlanId1" });
            DropIndex("dbo.MachineAllocations", new[] { "ProductionPlan_ProductionPlanId" });
            AlterColumn("dbo.Orders", "OrderStatus", c => c.String());
            AlterColumn("dbo.PurchaseOrders", "Status", c => c.String());
            AlterColumn("dbo.Components", "MinimumOrderQuantity", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.ProductionPlans", "ProductComponent_ProductComponentId");
            DropColumn("dbo.ProductionPlans", "OrderDetail_OrderDetailId");
            DropColumn("dbo.ProductionPlans", "Order_OrderId");
            DropColumn("dbo.ProductionPlans", "MachineAllocation_MachineAllocationId");
            DropColumn("dbo.ProductionPlans", "Inventory_InventoryId");
            DropColumn("dbo.ProductionPlans", "Component_ComponentId");
            DropColumn("dbo.MachineAllocations", "ProductionPlan_ProductionPlanId1");
            DropColumn("dbo.MachineAllocations", "ProductionPlan_ProductionPlanId");
            CreateIndex("dbo.MachineAllocations", "ProductionPlanId");
            AddForeignKey("dbo.MachineAllocations", "ProductionPlanId", "dbo.ProductionPlans", "ProductionPlanId", cascadeDelete: true);
        }
    }
}
