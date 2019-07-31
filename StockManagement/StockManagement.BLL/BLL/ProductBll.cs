using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Models.Models;
using StockManagement.Repository1.Repo;

namespace StockManagement.BLL.BLL
{
   public class ProductBll
    {
        ProductRepo _productRepo=new ProductRepo();
        public bool Save(Product product)
        {
            return _productRepo.Save(product);

        }

        public bool Update(Product product)
        {
            return _productRepo.Update(product);
        }

        public bool Delete(Product product)
        {
            return _productRepo.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productRepo.GetAll();
        }

        public Product GetById(Product product)
        {
            return _productRepo.GetById(product);
        }

        public bool IsExist(Product product)
        {
            return _productRepo.IsExist(product);
        }

        public bool UpdateIsExist(Product product)
        {
            return _productRepo.UpdateIsExist(product);
        }
    }
}
