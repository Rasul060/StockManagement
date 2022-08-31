using Microsoft.EntityFrameworkCore;
using Product.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DataAccess.Concrete.EntityFramework.Contexts
{
    public class ProductApiContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=RASUL\SQLEXPRESS;Database=ProductManagement;Trusted_Connection=true");
        }

        public DbSet<ProductItem> Products { get; set; }
        public DbSet<ProductCategory> Categories { get; set; }
    }
}
