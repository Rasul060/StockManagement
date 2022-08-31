using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Stock.Entities;

namespace Stock.Business.ValidationRules.FluentValidation
{
    public class ProductStockValidator:AbstractValidator<ProductStock>
    {
        public ProductStockValidator()
        {
            RuleFor(p=> p.ProductId).NotNull();
            RuleFor(p => p.StockCount).NotEmpty().WithMessage("stock must not be empty!");
        }

    }
}
