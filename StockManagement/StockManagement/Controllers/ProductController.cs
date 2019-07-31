using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StockManagement.BLL.BLL;
using StockManagement.Models.Models;

namespace StockManagement.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        ProductBll _productBll=new ProductBll();
        public string Save(Product product)
        {

            string Output = "";

            var IsExist = _productBll.IsExist(product);
            if (!IsExist)
            {
                bool success = _productBll.Save(product);

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

        public string Update(Product product)
        {

            string Output = "";

            bool IsExist = _productBll.UpdateIsExist(product);
            if (!IsExist)
            {
                bool success = _productBll.Update(product);

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

        public string Delete(Product product)
        {
            string Output = "";

            bool success = _productBll.Delete(product);

            if (success)
            {
                Output = "Success";
            }
            else
            {
                Output = "Fail";
            }

            return Output;
        }

        public string GetAll()
        {
            string output = "Name\t\tCode" + Environment.NewLine;
            string Massage = "";
            var ProductList = _productBll.GetAll();
            foreach (var row in ProductList)
            {
                Massage = Massage + "" + row.Name + "\t\t" + row.Code + "\n";
            }

            return "Name\t\tCode" + Massage;
        }

        public string GetById(Product product)
        {

            if (product.Id == null)
            {
                return "Input Id";
            }
            else
            {
                var data = _productBll.GetById(product);
                return data.Code + " " + data.Name;
            }
        }

    }
}