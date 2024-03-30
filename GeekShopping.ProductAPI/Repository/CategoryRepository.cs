using AutoMapper;
using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Model;
using GeekShopping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Repository
{
  public class CategoryRepository : ICategoryRepository
  {
    private readonly MySQLContext _context;
    private readonly IMapper _mapper;

    public CategoryRepository(MySQLContext context, IMapper mapper)
    {
      _context = context;
      _mapper = mapper;
    }

    public async Task<List<CategoryVO>> GetAllCategory()
    {
      try
      {
        List<Category> categorys = await _context.Category.ToListAsync();
        return _mapper.Map<List<CategoryVO>>(categorys);
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
    }
  }
}
