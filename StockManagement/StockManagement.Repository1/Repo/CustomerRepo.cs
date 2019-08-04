using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.DatabaseContext;
using StockManagement.Models.Models;

namespace StockManagement.Repository1.Repo
{
    public class CustomerRepo
    {

        StockManagementDbContext db = new StockManagementDbContext();

        public bool Save(Customer customer)
        {
            db.Customers.Add(customer);
            int success = db.SaveChanges();
            if (success > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Update(Customer customer)
        {
            var data = db.Customers.FirstOrDefault(c => c.Id == customer.Id);
            data.Name = customer.Name;
            data.Code = customer.Code;
            data.Address = customer.Address;
            data.Contact = customer.Contact;
            data.Email = customer.Email;
            data.LoyaltyPoint = customer.LoyaltyPoint;
            data.UpdateBy = customer.UpdateBy;
            data.UpdateDate = DateTime.Now;
            int success = db.SaveChanges();
            if (success > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool Delete(Customer customer)
        {
            var data = db.Customers.FirstOrDefault(c => c.Id == customer.Id);
            data.DeleteBy = customer.DeleteBy;
            data.DeleteDate=DateTime.Now;
            int success = db.SaveChanges();
            if (success>0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public List<Customer> GetAll()
        {
            var data = db.Customers.FirstOrDefault(c => c.DeleteDate != null);
         
        }
    }
}
