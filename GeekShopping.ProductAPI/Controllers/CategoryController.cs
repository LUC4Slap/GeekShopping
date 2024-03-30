using GeekShopping.ProductAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controllers
{
  [Route("api/v1/[controller]")]
  [ApiController]
  public class CategoryController : ControllerBase
  {
    private ICategoryRepository _repository;
    public CategoryController(ICategoryRepository repository)
     => _repository = repository ?? throw new ArgumentNullException(nameof(repository));

    [HttpGet()]
    public async Task<IActionResult> GetAllCategorys()
    {
      try
      {
        var categorys = await _repository.GetAllCategory();
        return Ok(categorys);
      }
      catch (Exception ex)
      {
        return BadRequest(ex.Message);
      }
    }
  }
}
