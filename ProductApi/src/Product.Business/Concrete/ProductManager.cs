using Business.ValidationRules.FluentValidation;
using FluentValidation.Results;
using Product.Business.Abstract;
using Product.Core;
using Product.DataAccess.Abstract;
using Product.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public ProductItem GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
        }

        public List<ProductItem> GetList()
        {
            return _productDal.GetList().Where(x=>x.IsDeleted == false).ToList();
        }

        public void Add(ProductItem product)
        {
            string errors = CheckValidation(product);
            if(errors.Length > 0)
            {
                throw new Exception(errors);
            }
            _productDal.Add(product);
        }

        public void Delete(ProductItem product)
        {
            product.IsDeleted = true;
            _productDal.Update(product);
        }

        public void Update(ProductItem product)
        {
            _productDal.Update(product);
        }

        private string CheckValidation(ProductItem product)
        {
            ProductValidator validator = new ProductValidator();

            ValidationResult resuts = validator.Validate(product);

            List<string> listedErrors = new List<string>();

            if(resuts.IsValid == false)
            {
                foreach (ValidationFailure failure in resuts.Errors)
                {
                    listedErrors.Add($"{failure.PropertyName}: {failure.ErrorMessage}");
                }
            }

            string errors = string.Join(",", listedErrors);

            return errors;
        }
    }
}
