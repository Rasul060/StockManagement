using Autofac.Extras.Moq;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Moq;
using Product.Business.Abstract;
using Product.Business.Concrete;
using Product.DataAccess.Abstract;
using Product.Entities.Concrete;

namespace Product.Business.Test;

public class ProductTest
{

  //this test prepared for testing add method on business layer
    [Fact]
    public void AddProductTest()
    {
        using(var mock = AutoMock.GetLoose())
        {
            var product = GetSampleProductItem()[0];

            mock.Mock<IProductDal>()
                .Setup(x => x.Add(product));

            var cls = mock.Create<ProductManager>();

            cls.Add(product);

            mock.Mock<IProductDal>()
                .Verify(x => x.Add(product), Times.Exactly(1));

        }
    }

    private List<ProductItem> GetSampleProductItem()
    {
        List<ProductItem> products = new List<ProductItem>
        {
            new ProductItem
            {
            ProductId = 1,
            ProductName = "fffd",
            ProductCategoryId = 1,
            Price = 10,
            CreatedDate = Convert.ToDateTime("2022-08-30 19:55:52.4860000"),
            State = true,
            IsDeleted = false
            }
        };
        return products;
    }

}