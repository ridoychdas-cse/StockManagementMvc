using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Models.Models;

namespace StockManagement.DatabaseContext
{
    public class StockManagementDbContext:DbContext
    {
        public DbSet<Category> Categories { get; set; } 
        public  DbSet<Product> Products { get; set; }
    }
}
