using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public bool Add(Customer customer, out string message)
        {
            var existingCustomer = _customerDal.GetAll().Where(x => x.CustomerName == customer.CustomerName).FirstOrDefault();
            if (existingCustomer != null)
            {
                message = "Customer already exists with the name: " + customer.CustomerName;
                return false;
            }
            _customerDal.Add(customer);
            message = "Customer added successfully.";
            return true;
        }

        public bool Delete(Customer customer, out string message)
        {
            var existingCustomer = _customerDal.GetAll()
                .Where(x=>x.CustomerName == customer.CustomerName)
                .Select(x=>x.CustomerId)
                .FirstOrDefault();
            if (existingCustomer == null)
            {
                message = "Customer doesn't exist : " + customer.CustomerName;
                return false;
            }
            _customerDal.Delete(customer);
            message ="Customer deleted successfully";
            return true;

        }

        public Customer Get(string customerName)
        {
            return _customerDal.Get(x=>x.CustomerName == customerName);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public int GetCustomerId(string customerName)
        {
            return _customerDal.GetAll()
                .Where(x=>x.CustomerName == customerName)
                .Select (x=>x.CustomerId)
                .FirstOrDefault();

        }

        public bool Update(Customer customer, out string message)
        {
            var existingCustomer = _customerDal.GetAll()
                .Where(x=>x.CustomerName == customer.CustomerName)
                .Select(x=>x.CustomerId)
                .FirstOrDefault();

            if (existingCustomer == null)
            {
                message = "Customer doesn't exist : " + customer.CustomerName;
                return false;
            }
            _customerDal.Update(customer);
            message = "Customer Updated Successfully";
            return true;
            
        }
    }
}
