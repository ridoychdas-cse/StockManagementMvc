using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Models.Models
{
   public class Product:LoginInfo
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int ReorderLavel { get; set; }
        public string Discripation { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
