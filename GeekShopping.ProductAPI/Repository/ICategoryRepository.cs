using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Model;

namespace GeekShopping.ProductAPI.Repository
{
  public interface ICategoryRepository
  {
    Task<List<CategoryVO>> GetAllCategory();
  }
}
