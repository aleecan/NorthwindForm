using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContext
{
    public class NService
    {
        public NService()
        {

        }

        public List<Customer> GetCustomers()
        {
            using (NorthwindEntities datacontext = new NorthwindEntities())
            {
                return datacontext.Customers.ToList();
            }
            
        }

        public void SaveCustomer(Customer customer) {
            using (NorthwindEntities datacontext = new NorthwindEntities())
            {
                var result = datacontext.Customers.Add(customer);
                if (string.IsNullOrEmpty(result.CustomerID))
                {
                    new NullReferenceException();
                }
                else
                    datacontext.SaveChanges();
            }
        }

        public List<CustOrderHist_Result> GetCustomerHist(string customerId)
        {
            using (NorthwindEntities datacontext = new NorthwindEntities())
            {
                return datacontext.CustOrderHist(customerId).ToList();
            }
        }
    }
}
