using Stock.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Business.Abstract
{
    public interface IProductStockService
    {
        int GetStock(int productId);
        void AddStock(ProductStock stock);
        void RemoveStock(ProductStock stock);
    }
}
