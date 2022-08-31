using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Product.Entities.Concrete;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<ProductItem>
    {
        public ProductValidator()
        {
            RuleFor(p=> p.ProductId).NotNull();
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Product name must not be empty!")
                .Length(2,50).WithMessage("Count characters are so much");
        }

    }
}
