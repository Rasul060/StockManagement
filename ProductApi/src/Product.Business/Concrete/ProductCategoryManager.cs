using Product.Business.Abstract;
using Product.DataAccess.Abstract;
using Product.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Business.Concrete
{
    public class ProductCategoryManager : IProductCategoryService
    {
        private IProductCategoryDal _categoryDal;

        public ProductCategoryManager(IProductCategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<ProductCategory> GetList()
        {
            return _categoryDal.GetList().ToList();
        }

        public void Add(ProductCategory category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(ProductCategory category)
        {
            _categoryDal.Delete(category);
        }

        public void Update(ProductCategory category)
        {
            _categoryDal.Update(category);
        }
    }
}
