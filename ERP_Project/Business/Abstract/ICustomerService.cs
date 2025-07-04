using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        bool Add(Customer customer,out string message);
        bool Delete(Customer customer,out string message);
        int GetCustomerId(string customerName);

        bool Update(Customer customer,out string message);
        Customer Get(string customerName);
        List<Customer> GetAll();

    }
}
