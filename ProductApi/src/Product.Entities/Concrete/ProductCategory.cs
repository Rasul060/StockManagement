using Product.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Product.Entities.Concrete
{
    public class ProductCategory : IEntity
    {
        [Key]
        public int ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; }
    }
}
