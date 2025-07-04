using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using System.Reflection.Emit;
using System.Data.Entity;


namespace DataAccess.Concrete
{
    public class Context : DbContext
    {
        // here is for mapping (EntitiyFramework with Azure SQL)
     
        public DbSet <Users> User { get; set; }
        public DbSet<Department> Department { get;set; }
        public DbSet<Role> Role { get;set; }
        public DbSet<Components> Component { get;set; }
        public DbSet<Machine> Machine { get;set; }
        public DbSet<Supplier> Supplier { get;set; }
        public DbSet<Customer> Customer { get;set; }
        public DbSet<Order> Order { get;set;}
        public DbSet<OrderDetail> OrderDetail { get;set; }
        public DbSet<Screen> Screen { get;set; }
        public DbSet<UserScreen> UserScreen { get;set; }
        public DbSet<ComponentSupplier> ComponentSupplier { get;set; }
        public DbSet<ProductComponent> ProductComponent { get;set; }    
        public DbSet<PurchaseOrder> PurchaseOrder { get;set; }
        public DbSet<PurchaseOrderDetail> PurchaseOrderDetail { get;set; }
        public DbSet<Inventories> Inventory { get;set; }
        public DbSet<ComponentMachine> ComponentMachine { get;set; }    
        public DbSet<ProductionPlan> ProductionPlan { get;set; }    
        public DbSet<MachineAllocation> MachineAllocation { get;set; }  
        public DbSet<Product> Product { get;set; }
    }
        

       
    
}
