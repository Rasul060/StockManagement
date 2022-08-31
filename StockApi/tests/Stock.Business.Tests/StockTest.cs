using Autofac.Extras.Moq;
using Moq;
using Stock.Business.Concrete;
using Stock.DataAccess.Abstract;
using Stock.Entities;

namespace Stock.Business.Tests;

public class StockTest
{
    [Fact]
    public void GetStockDataTest()
    {
        using (var mock = AutoMock.GetLoose())
        {
            var product = GetSampleProductItem()[0];

            mock.Mock<IProductStockDal>()
                .Setup(x => x.Get(x=>x.Id == 1))
                .Returns(product);

            var cls = mock.Create<ProductStockManager>();
            var expected = GetSampleProductItem();
            var actual = cls.GetStock(1);

            Assert.True(actual != null);
        }
    }

    private List<ProductStock> GetSampleProductItem()
    {
        List<ProductStock> stocks = new List<ProductStock>
        {
            new ProductStock
            {
            Id = 1,
            ProductId = 1,
            StockCount = 5,
            }
        };
        return stocks;
    }
}