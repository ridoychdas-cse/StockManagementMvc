using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StockManagement.BLL.BLL;
using StockManagement.Models.Models;

namespace StockManagement.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryBll _categoryBll=new CategoryBll();
        public string Save(Category category)
        {
            string Output = "";
           Category _category=new Category();
           _category.Code = category.Code;
           _category.Name = category.Name;
           _category.AddBy = category.AddBy;
           _category.AddDate=DateTime.Now;
           bool IsExist = _categoryBll.IsExist(category);
           if (!IsExist)
           {
               bool success = _categoryBll.Save(_category);

               if (success)
               {
                   Output= "Success";
               }
               else
               {
                   Output= "Fail";
               }
           }
           else
           {
               Output = "Same Name Alreay Save";
           }

           return Output;
        }

        public string Update(Category category)
        {

            string Output = "";
            Category _category = new Category();
            _category.Id = Convert.ToInt32(category.Id);
            _category.Code = category.Code;
            _category.Name = category.Name;
            _category.AddBy = category.AddBy;
            _category.AddDate = DateTime.Now;
            bool IsExist = _categoryBll.UpdateIsExist(category);
            if (!IsExist)
            {
                bool success = _categoryBll.Update(_category);

                if (success)
                {
                    Output = "Success";
                }
                else
                {
                    Output = "Fail";
                }
            }
            else
            {
                Output = "Same Name Alreay Save";
            }

            return Output;
        }
     
    }
}