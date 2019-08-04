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

        [HttpGet]
        public ActionResult Save()
        {
            return View();
        }




        [HttpPost]
        public ActionResult Save(Category category)
        {


            if (ModelState.IsValid)
            {
                category.AddDate = DateTime.Now;
                bool IsExist = _categoryBll.IsExist(category);
                if (!IsExist)
                {
                    bool success = _categoryBll.Save(category);

                    if (success)
                    {
                        ViewBag.Success = "Success";
                    }
                    else
                    {
                        ViewBag.Fail = "Fail";
                    }
                }
                else
                {
                    ViewBag.AlreadySave = "Same Name Alreay Save";
                }


            }
            else
            {
                ViewBag.Error = "Error";
            }
            return View();
        }
        [HttpGet]

        public ActionResult Update(int Id)
        {
            Category category=new Category();
            category.Id = Id;
            Category data = _categoryBll.GetById(category);
            return View(data);

        }
        [HttpPost]
        public ActionResult Update(Category category)
        {

            if (ModelState.IsValid)
            {
                category.AddDate = DateTime.Now;
                bool IsExist = _categoryBll.UpdateIsExist(category);
                if (!IsExist)
                {
                    bool success = _categoryBll.Update(category);

                    if (success)
                    {
                        ViewBag.Success = "Success";
                    }
                    else
                    {
                        ViewBag.Fail = "Fail";
                    }
                }
                else
                {
                    ViewBag.AlreadySave = "Same Name Alreay Save";
                }


            }
            else
            {
                ViewBag.Error = "Error";
            }
            return View(category);
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            List<Category> categorieList = _categoryBll.GetAll();
            Category category=new Category();
            category.Categories = categorieList;
            return View(category);
        }
     
    }
}