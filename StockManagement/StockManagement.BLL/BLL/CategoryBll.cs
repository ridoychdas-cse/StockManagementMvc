using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Models.Models;
using StockManagement.Repository1.Repo;

namespace StockManagement.BLL.BLL
{
   public class CategoryBll
    {
      CategoryRepository _categoryRepository=new CategoryRepository();

      public bool Save(Category category)
      {
          return _categoryRepository.Save(category);
      }

      public bool IsExist(Category category)
      {
          return _categoryRepository.IsExist(category);
      }

      public bool UpdateIsExist(Category category)
      {
          return _categoryRepository.UpdateIsExist(category);
      }

      public bool Update(Category category)
      {
          return _categoryRepository.Updaete(category);
      }
    }
}
