﻿using Stock.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Entities
{
    public class ProductStock : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int StockCount { get; set; }
    }
}
