using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.DatabaseContext;
using StockManagement.Models.Models;

namespace StockManagement.Repository1.Repo
{
   public class ProductRepo
    {

        StockManagementDbContext Db=new StockManagementDbContext();
        public bool Save(Product product)
        {
            Db.Products.Add(product);
            int success = Db.SaveChanges();
            if (success>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Update(Product product)
        {

            var data = Db.Products.FirstOrDefault(c => c.Id == product.Id);
            data.Code = product.Code;
            data.Name = product.Name;
            data.Discripation = product.Discripation;
            data.ReorderLavel = product.ReorderLavel;
            data.CategoryId = product.CategoryId;
            int success = Db.SaveChanges();
            if (success>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(Product product)
        {
            var data = Db.Products.FirstOrDefault(c => c.Id == product.Id);
            Db.Products.Remove(data);
            int success = Db.SaveChanges();
            if (success>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Product> GetAll()
        {
            var ProductList = Db.Products.ToList();
            return ProductList;
        }

        public Product GetById(Product product)
        {
            var data = Db.Products.FirstOrDefault(c => c.Id == product.Id);
            return data;
        }

        public bool IsExist(Product product)
        {/* && c.Code == product.Code*/
            var data = Db.Products.FirstOrDefault(c =>c.Name == product.Name);
            if (data==null)
            {
                return false;

            }
            else
            {
                return true;
            }
        }
        public bool UpdateIsExist(Product product)
        {
            var data = Db.Products.FirstOrDefault(c =>c.Id != product.Id && c.Name == product.Name && c.Code == product.Code);
            if (data == null)
            {
                return false;

            }
            else
            {
                return true;
            }
        }

    }
}
