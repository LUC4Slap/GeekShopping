using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GeekShopping.ProductAPI.Model.Base;

namespace GeekShopping.ProductAPI.Model
{
  [Table("category")]
  public class Category : BaseEntity
  {
    [Column("name")]
    [Required]
    public string Name { get; set; }

    [Column("description")]
    [Required]
    public string Description { get; set; }
  }
}
