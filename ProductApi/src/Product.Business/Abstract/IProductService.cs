using Product.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Business.Abstract
{
    public interface IProductService
    {
        ProductItem GetById(int productId);
        List<ProductItem> GetList();
        void Add(ProductItem product);
        void Delete(ProductItem product);
        void Update(ProductItem product);
    }
}
