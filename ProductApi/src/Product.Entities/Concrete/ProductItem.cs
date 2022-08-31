using Product.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Product.Entities.Concrete
{
    public class ProductItem : IEntity
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductCategoryId { get; set; }
        public double Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool State { get; set; }
        public bool IsDeleted { get; set; }
    }
}
