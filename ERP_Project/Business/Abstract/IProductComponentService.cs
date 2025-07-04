using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Concrete;
using Entities.Concrete;
using ViewModel;

namespace Business.Abstract
{
    public interface IProductComponentService
    {
        void Add(ProductComponent productComponent);
        void Delete(ProductComponent productComponent);
        List<ProductComponent> GetAll();
        void Update(ProductComponent productComponent);
        ProductComponent GetByProductId(int productId);
        List<string> GetByProductCode(string productCode);
        List<ProductComponent> GetComponentsByProductId(int productId);
        List<ProductViewModel> ProductDetails();
        List<ProductComponent> ShowAll();

    }
}
