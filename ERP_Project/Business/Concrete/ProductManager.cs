using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Business.Abstract;
using Entities.Concrete;


namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        //Dependency Injection
         private IProductDal _productDal;
         public ProductManager(IProductDal productDal)
         {
             _productDal = productDal;
         }

        public void Add(Product product)
        {
                 _productDal.Add(product);

           
        }

        public void Delete(Product product,out string message)
        {
            var isEmpty = _productDal.GetAll().Any();
            if (isEmpty != null)
            {
                _productDal.Delete(product);
                message ="Product Deleted";

            }
            else
            {
                message ="Nothing To Delete";
                return;
            }
            
        }

        public int GetProductId(string productCode)
        {
            return _productDal.GetAll()
                .Where(x=>x.ProductCode ==productCode)
                .Select(x=>x.ProductId)
                .SingleOrDefault();
        }
        public List<Product> GetAll()
        {
          return  _productDal.GetAll();
        }

        public void Update(Product product,out string message)
        {
            var isEmpty = _productDal.GetAll().Any();
            
            if (isEmpty != null)
            {
                _productDal.Update(product);
                message = "Product Updated";
            }
            else
            {
                message ="Nothing to Update";
                return;
            }
            
        }

        public Product GetProductByCode(string productCode)
        {
            return _productDal.GetAll()
                .Where(x=>x.ProductCode == productCode)
                .FirstOrDefault();
                
        }

        public Product GetProductById(int productId)
        {
           return _productDal.Get(x=>x.ProductId ==productId);
        }
    }
}
