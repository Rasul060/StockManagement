using Stock.Core.DataAccess;
using Stock.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.DataAccess.Abstract
{
    public interface IProductStockDal : IEntityRepository<ProductStock>
    {
    }
}
