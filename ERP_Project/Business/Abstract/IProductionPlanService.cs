using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;
using Entities.Concrete;
namespace Business.Abstract
{
    public interface IProductionPlanService
    {

        List<ProductionPlan> GetAll();
        List<ProductionPlan> ShowAll();
        void Add(ProductionPlan productionPlan);
        List<ProductionPlan> CreateProductionPlan();
        List<ProductionPlanViewModel> GetProductionPlans();


    }
}
