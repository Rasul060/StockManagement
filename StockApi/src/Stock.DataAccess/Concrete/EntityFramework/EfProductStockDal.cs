using Stock.Core.DataAccess.EntityFramework;
using Stock.DataAccess.Abstract;
using Stock.DataAccess.Concrete.EntityFramework.Contexts;
using Stock.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.DataAccess.Concrete.EntityFramework
{
    public class EfProductStockDal : EfEntityRepositoryBase<ProductStock, ProductStockApiContext>, IProductStockDal
    {
    }
}
