using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        List <Product> GetAll();
        
        int GetProductId (string ProductCode);
        void Add (Product product);
        void Update (Product product,out string message);
        void Delete (Product product, out string message);
        Product GetProductByCode(string productCode);
        Product GetProductById (int productId);
        
    }
}
