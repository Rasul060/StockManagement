using Microsoft.EntityFrameworkCore;
using Stock.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.DataAccess.Concrete.EntityFramework.Contexts
{
    public class ProductStockApiContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=RASUL\SQLEXPRESS;Database=StockManagement;Trusted_Connection=true");
        }

        public DbSet<ProductStock> ProductStocks { get; set; }
    }
}
