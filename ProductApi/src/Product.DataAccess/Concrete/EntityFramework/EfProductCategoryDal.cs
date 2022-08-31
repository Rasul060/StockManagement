using Product.Core.DataAccess.EntityFramework;
using Product.DataAccess.Abstract;
using Product.DataAccess.Concrete.EntityFramework.Contexts;
using Product.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DataAccess.Concrete.EntityFramework
{
    public class EfProductCategoryDal : EfEntityRepositoryBase<ProductCategory, ProductApiContext>, IProductCategoryDal
    {
    }
}
