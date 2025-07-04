namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ERPUpdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Components",
                c => new
                    {
                        ComponentId = c.Int(nullable: false, identity: true),
                        ComponentCode = c.String(),
                        ComponentDefinition = c.String(),
                        MinimumOrderQuantity = c.Int(nullable: false),
                        LeadTime = c.Int(nullable: false),
                        ComponentUnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Product_ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.ComponentId)
                .ForeignKey("dbo.Products", t => t.Product_ProductId)
                .Index(t => t.Product_ProductId);
            
            CreateTable(
                "dbo.ComponentMachines",
                c => new
                    {
                        ComponentMachineId = c.Int(nullable: false, identity: true),
                        MachineId = c.Int(nullable: false),
                        ComponentId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        SubCode = c.String(),
                    })
                .PrimaryKey(t => t.ComponentMachineId)
                .ForeignKey("dbo.Components", t => t.ComponentId, cascadeDelete: true)
                .ForeignKey("dbo.Machines", t => t.MachineId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.MachineId)
                .Index(t => t.ComponentId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Machines",
                c => new
                    {
                        MachineId = c.Int(nullable: false, identity: true),
                        MachineName = c.String(),
                        MachineProcess = c.String(),
                        CapacityPerDay = c.Int(nullable: false),
                        isAvaliable = c.Boolean(nullable: false),
                        SetupTime = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.MachineId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductCode = c.String(),
                        ProductDefinition = c.String(),
                        ProductVersion = c.Int(nullable: false),
                        ProductPrice = c.Double(nullable: false),
                        ProductStock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderDetailId = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderDetailId)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.ProductId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        CustomerAddress = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        CustomerOrderNumber = c.String(),
                        OrderDate = c.DateTime(nullable: false),
                        DeliveryDate = c.DateTime(nullable: false),
                        OrderStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: false)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.ProductComponents",
                c => new
                    {
                        ProductComponentId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        ComponentId = c.Int(nullable: false),
                        ComponentQuantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductComponentId)
                .ForeignKey("dbo.Components", t => t.ComponentId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.ComponentId);
            
            CreateTable(
                "dbo.ComponentSuppliers",
                c => new
                    {
                        ComponentSupplierId = c.Int(nullable: false, identity: true),
                        ComponentId = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ComponentSupplierId)
                .ForeignKey("dbo.Components", t => t.ComponentId, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.ComponentId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        SupplierId = c.Int(nullable: false, identity: true),
                        SupplierName = c.String(),
                        SupplierAddress = c.String(),
                    })
                .PrimaryKey(t => t.SupplierId);
            
            CreateTable(
                "dbo.PurchaseOrders",
                c => new
                    {
                        PurchaseOrderId = c.Int(nullable: false, identity: true),
                        SupplierId = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        DeliveryDate = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PurchaseOrderId)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.PurchaseOrderDetails",
                c => new
                    {
                        PurchaseOrderDetailId = c.Int(nullable: false, identity: true),
                        PurchaseOrderId = c.Int(nullable: false),
                        ComponentId = c.Int(nullable: false),
                        OrderQuantity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PurchaseOrderDetailId)
                .ForeignKey("dbo.Components", t => t.ComponentId, cascadeDelete: true)
                .ForeignKey("dbo.PurchaseOrders", t => t.PurchaseOrderId, cascadeDelete: true)
                .Index(t => t.PurchaseOrderId)
                .Index(t => t.ComponentId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        UserPassword = c.String(),
                        Name = c.String(),
                        Surname = c.String(),
                        PhoneNumber = c.String(),
                        SupervisorUserName = c.String(),
                        Address = c.String(),
                        DepartmentId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.DepartmentId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateTable(
                "dbo.UserScreens",
                c => new
                    {
                        UserScreenId = c.Int(nullable: false, identity: true),
                        ScreenId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserScreenId)
                .ForeignKey("dbo.Screens", t => t.ScreenId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.ScreenId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Screens",
                c => new
                    {
                        ScreenId = c.Int(nullable: false, identity: true),
                        ScreenName = c.String(),
                    })
                .PrimaryKey(t => t.ScreenId);
            
            CreateTable(
                "dbo.Inventories",
                c => new
                    {
                        InventoryId = c.Int(nullable: false, identity: true),
                        InventoryEntityId = c.Int(nullable: false),
                        InventoryEntityCode = c.String(),
                        InventoryEntityDefinition = c.String(),
                        StockQuantity = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        Component_ComponentId = c.Int(),
                        Product_ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.InventoryId)
                .ForeignKey("dbo.Components", t => t.Component_ComponentId)
                .ForeignKey("dbo.Products", t => t.Product_ProductId)
                .Index(t => t.Component_ComponentId)
                .Index(t => t.Product_ProductId);
            
            CreateTable(
                "dbo.MachineAllocations",
                c => new
                    {
                        MachineAllocationId = c.Int(nullable: false, identity: true),
                        MachineId = c.Int(nullable: false),
                        ComponentId = c.Int(nullable: false),
                        SubCode = c.String(),
                        QuantityToProduce = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        ProductionTimeInDays = c.Int(nullable: false),
                        ProductionPlan_ProductionPlanId = c.Int(),
                    })
                .PrimaryKey(t => t.MachineAllocationId)
                .ForeignKey("dbo.Components", t => t.ComponentId, cascadeDelete: true)
                .ForeignKey("dbo.Machines", t => t.MachineId, cascadeDelete: true)
                .ForeignKey("dbo.ProductionPlans", t => t.ProductionPlan_ProductionPlanId)
                .Index(t => t.MachineId)
                .Index(t => t.ComponentId)
                .Index(t => t.ProductionPlan_ProductionPlanId);
            
            CreateTable(
                "dbo.ProductionPlans",
                c => new
                    {
                        ProductionPlanId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        SubCode = c.String(),
                        QuantityToProduce = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        Component_ComponentId = c.Int(),
                        ComponentMachine_ComponentMachineId = c.Int(),
                        Inventory_InventoryId = c.Int(),
                        Machine_MachineId = c.Int(),
                        MachineAllocation_MachineAllocationId = c.Int(),
                        Order_OrderId = c.Int(),
                        OrderDetail_OrderDetailId = c.Int(),
                        ProductComponent_ProductComponentId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductionPlanId)
                .ForeignKey("dbo.Components", t => t.Component_ComponentId)
                .ForeignKey("dbo.ComponentMachines", t => t.ComponentMachine_ComponentMachineId)
                .ForeignKey("dbo.Inventories", t => t.Inventory_InventoryId)
                .ForeignKey("dbo.Machines", t => t.Machine_MachineId)
                .ForeignKey("dbo.MachineAllocations", t => t.MachineAllocation_MachineAllocationId)
                .ForeignKey("dbo.Orders", t => t.Order_OrderId)
                .ForeignKey("dbo.OrderDetails", t => t.OrderDetail_OrderDetailId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.ProductComponents", t => t.ProductComponent_ProductComponentId)
                .Index(t => t.ProductId)
                .Index(t => t.Component_ComponentId)
                .Index(t => t.ComponentMachine_ComponentMachineId)
                .Index(t => t.Inventory_InventoryId)
                .Index(t => t.Machine_MachineId)
                .Index(t => t.MachineAllocation_MachineAllocationId)
                .Index(t => t.Order_OrderId)
                .Index(t => t.OrderDetail_OrderDetailId)
                .Index(t => t.ProductComponent_ProductComponentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductionPlans", "ProductComponent_ProductComponentId", "dbo.ProductComponents");
            DropForeignKey("dbo.ProductionPlans", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductionPlans", "OrderDetail_OrderDetailId", "dbo.OrderDetails");
            DropForeignKey("dbo.ProductionPlans", "Order_OrderId", "dbo.Orders");
            DropForeignKey("dbo.MachineAllocations", "ProductionPlan_ProductionPlanId", "dbo.ProductionPlans");
            DropForeignKey("dbo.ProductionPlans", "MachineAllocation_MachineAllocationId", "dbo.MachineAllocations");
            DropForeignKey("dbo.ProductionPlans", "Machine_MachineId", "dbo.Machines");
            DropForeignKey("dbo.ProductionPlans", "Inventory_InventoryId", "dbo.Inventories");
            DropForeignKey("dbo.ProductionPlans", "ComponentMachine_ComponentMachineId", "dbo.ComponentMachines");
            DropForeignKey("dbo.ProductionPlans", "Component_ComponentId", "dbo.Components");
            DropForeignKey("dbo.MachineAllocations", "MachineId", "dbo.Machines");
            DropForeignKey("dbo.MachineAllocations", "ComponentId", "dbo.Components");
            DropForeignKey("dbo.Inventories", "Product_ProductId", "dbo.Products");
            DropForeignKey("dbo.Inventories", "Component_ComponentId", "dbo.Components");
            DropForeignKey("dbo.UserScreens", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserScreens", "ScreenId", "dbo.Screens");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Users", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.PurchaseOrders", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.PurchaseOrderDetails", "PurchaseOrderId", "dbo.PurchaseOrders");
            DropForeignKey("dbo.PurchaseOrderDetails", "ComponentId", "dbo.Components");
            DropForeignKey("dbo.ComponentSuppliers", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.ComponentSuppliers", "ComponentId", "dbo.Components");
            DropForeignKey("dbo.Components", "Product_ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductComponents", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductComponents", "ComponentId", "dbo.Components");
            DropForeignKey("dbo.OrderDetails", "ProductId", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.ComponentMachines", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ComponentMachines", "MachineId", "dbo.Machines");
            DropForeignKey("dbo.ComponentMachines", "ComponentId", "dbo.Components");
            DropIndex("dbo.ProductionPlans", new[] { "ProductComponent_ProductComponentId" });
            DropIndex("dbo.ProductionPlans", new[] { "OrderDetail_OrderDetailId" });
            DropIndex("dbo.ProductionPlans", new[] { "Order_OrderId" });
            DropIndex("dbo.ProductionPlans", new[] { "MachineAllocation_MachineAllocationId" });
            DropIndex("dbo.ProductionPlans", new[] { "Machine_MachineId" });
            DropIndex("dbo.ProductionPlans", new[] { "Inventory_InventoryId" });
            DropIndex("dbo.ProductionPlans", new[] { "ComponentMachine_ComponentMachineId" });
            DropIndex("dbo.ProductionPlans", new[] { "Component_ComponentId" });
            DropIndex("dbo.ProductionPlans", new[] { "ProductId" });
            DropIndex("dbo.MachineAllocations", new[] { "ProductionPlan_ProductionPlanId" });
            DropIndex("dbo.MachineAllocations", new[] { "ComponentId" });
            DropIndex("dbo.MachineAllocations", new[] { "MachineId" });
            DropIndex("dbo.Inventories", new[] { "Product_ProductId" });
            DropIndex("dbo.Inventories", new[] { "Component_ComponentId" });
            DropIndex("dbo.UserScreens", new[] { "UserId" });
            DropIndex("dbo.UserScreens", new[] { "ScreenId" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Users", new[] { "DepartmentId" });
            DropIndex("dbo.PurchaseOrderDetails", new[] { "ComponentId" });
            DropIndex("dbo.PurchaseOrderDetails", new[] { "PurchaseOrderId" });
            DropIndex("dbo.PurchaseOrders", new[] { "SupplierId" });
            DropIndex("dbo.ComponentSuppliers", new[] { "SupplierId" });
            DropIndex("dbo.ComponentSuppliers", new[] { "ComponentId" });
            DropIndex("dbo.ProductComponents", new[] { "ComponentId" });
            DropIndex("dbo.ProductComponents", new[] { "ProductId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.OrderDetails", new[] { "CustomerId" });
            DropIndex("dbo.OrderDetails", new[] { "ProductId" });
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            DropIndex("dbo.ComponentMachines", new[] { "ProductId" });
            DropIndex("dbo.ComponentMachines", new[] { "ComponentId" });
            DropIndex("dbo.ComponentMachines", new[] { "MachineId" });
            DropIndex("dbo.Components", new[] { "Product_ProductId" });
            DropTable("dbo.ProductionPlans");
            DropTable("dbo.MachineAllocations");
            DropTable("dbo.Inventories");
            DropTable("dbo.Screens");
            DropTable("dbo.UserScreens");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Departments");
            DropTable("dbo.PurchaseOrderDetails");
            DropTable("dbo.PurchaseOrders");
            DropTable("dbo.Suppliers");
            DropTable("dbo.ComponentSuppliers");
            DropTable("dbo.ProductComponents");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Products");
            DropTable("dbo.Machines");
            DropTable("dbo.ComponentMachines");
            DropTable("dbo.Components");
        }
    }
}
