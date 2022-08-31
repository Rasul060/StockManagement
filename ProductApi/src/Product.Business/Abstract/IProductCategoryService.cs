using Product.Entities.Concrete;

namespace Product.Business.Abstract
{
    public interface IProductCategoryService
    {
        List<ProductCategory> GetList();
        void Add(ProductCategory category);
        void Update(ProductCategory category);
        void Delete(ProductCategory category);
    }
}
