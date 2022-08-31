using FluentValidation;
using FluentValidation.Results;
using Product.Business.Abstract;
using Stock.Business.Abstract;
using Stock.Business.ValidationRules.FluentValidation;
using Stock.DataAccess.Abstract;
using Stock.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Business.Concrete
{
    public class ProductStockManager : IProductStockService
    {
        private IProductStockDal _productStockDal;
        private IProductService _productService;

        public ProductStockManager(IProductStockDal productStockDal,
            IProductService productService)
        {
            _productStockDal = productStockDal;
            _productService = productService;
        }

        public void AddStock(ProductStock stock)
        {
            var product = _productService.GetById(stock.ProductId);
            if(product == null)
            {
                this.InvalidProductIdException();
            }

            var stockData = _productStockDal.Get(p => p.ProductId == stock.ProductId);
            if (stockData == null)
            {
                _productStockDal.Add(stock);
            }
            else
            {
                stockData.StockCount+=stock.StockCount;
                _productStockDal.Update(stock);
            }
        }

        public void RemoveStock(ProductStock stock)
        {
            var product = _productService.GetById(stock.ProductId);
            if (product == null)
            {
                this.InvalidProductIdException();
            }

            var stockData = _productStockDal.Get(p => p.ProductId == stock.ProductId);
            if(stockData == null || stockData.StockCount == 0)
            {
                throw new Exception("Out of stock");
            }
            stockData.StockCount -= stock.StockCount;
            
            _productStockDal.Update(stockData);
        }

        public int GetStock(int productId)
        {
            var product = _productService.GetById(productId);
            if (product == null)
            {
                this.InvalidProductIdException();
            }

            var stockData = _productStockDal.Get(p => p.ProductId == productId);
           
            return stockData == null ? 0 : stockData.StockCount;
        }

        private void InvalidProductIdException()
        {

            throw new Exception("InvalidProductId");
        }

        private string CheckValidation(ProductStock productStock)
        {
            ProductStockValidator validator = new ProductStockValidator();

            ValidationResult resuts = validator.Validate(productStock);

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
