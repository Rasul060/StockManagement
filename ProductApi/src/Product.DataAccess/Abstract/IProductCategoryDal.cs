using Product.Core.DataAccess;
using Product.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DataAccess.Abstract
{
    public interface IProductCategoryDal : IEntityRepository<ProductCategory>
    {
    }
}
