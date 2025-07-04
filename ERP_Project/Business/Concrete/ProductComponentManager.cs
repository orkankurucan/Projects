using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using ViewModel;

namespace Business.Concrete
{
    public class ProductComponentManager : IProductComponentService
    {
        private IProductComponentDal _productComponentDal;

        public ProductComponentManager(IProductComponentDal productComponentDal)
        {
            _productComponentDal = productComponentDal;
        }

        public void Add(ProductComponent productComponent)
        {
                _productComponentDal.Add(productComponent);
        }

        public void Delete(ProductComponent productComponent)
        {
                _productComponentDal.Delete(productComponent);
        }

        public List<ProductComponent> GetAll()
        {
            return _productComponentDal.GetAll();
        }

        public ProductComponent GetByProductId(int productId)
        {
            return _productComponentDal.Get(x => x.ProductId == productId);
        }

        public void Update(ProductComponent productComponent)
        {
                _productComponentDal.Update(productComponent);
        }

        public List<string> GetByProductCode(string productCode)
        {
            return _productComponentDal.GetAll()
                .Where(x => x.Product.ProductCode == productCode)
                .Select(x => x.Component.ComponentCode)
                .ToList();
        }

        public List<ProductComponent> GetComponentsByProductId(int productId)
        {

            var components = _productComponentDal.GetAll()
            .Where(x => x.ProductId == productId)
            .ToList();
            return
                components.Where(c => c != null).ToList();

        }

        public List<ProductViewModel> ProductDetails()
        {
            var products = _productComponentDal.ShowAll(null,x=>x.Product,x=>x.Component);
            
            if (products != null)
            {
                var productViewModel = products.Select(x=> new ProductViewModel()
                {
                    ProductId = x.ProductId,
                    ProductCode = x.Product.ProductCode,
                    ProductDefinition = x.Product.ProductDefinition,
                    ProductVersion =x.Product.ProductVersion,
                    ComponentId = x.Component.ComponentId,
                    ComponentCode = x.Component.ComponentCode,
                    ComponentDefinition = x.Component.ComponentDefinition,
                    ComponentQuantity = x.ComponentQuantity

                }).ToList();
                return productViewModel;
            }

            else
                return null;

        }

        public List<ProductComponent> ShowAll()
        {
            return _productComponentDal.ShowAll(null,x=>x.Product,x=>x.Component);
        }
    }
}
