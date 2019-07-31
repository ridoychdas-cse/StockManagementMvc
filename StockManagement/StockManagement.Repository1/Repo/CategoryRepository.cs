using StockManagement.DatabaseContext;
using StockManagement.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Repository1.Repo
{
  public  class CategoryRepository
    {
        StockManagementDbContext Db = new StockManagementDbContext();

        public bool Save(Category category)
        {
            Db.Categories.Add(category);
            int success = Db.SaveChanges();
            if (success > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateIsExist(Category category)
        {
            var Data = Db.Categories.FirstOrDefault(c =>
                c.Id != category.Id && c.Code == category.Code && c.Name == category.Name);
            if (Data!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsExist(Category category)
        {
            var Data = Db.Categories.FirstOrDefault(c => c.Code == category.Code && c.Name == category.Name);
            if (Data != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Updaete(Category category)
        {
            var Data = Db.Categories.FirstOrDefault(c => c.Id == category.Id);
            Data.Code = category.Code;
            Data.Name = category.Name;
            Data.UpdateBy = category.UpdateBy;
            Data.UpdateDate = category.UpdateDate;
            int Success = Db.SaveChanges();
            if (Success>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
  
}
