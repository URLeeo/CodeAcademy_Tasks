using System.ComponentModel.DataAnnotations;

namespace Fruitables.Areas.Admin.ViewModels.ProductVMs;

public class CreateProductVM
{
    [Required]
    public string Name { get; set; } = null!;
    [Required]
    public string Description { get; set; } = null!;
    [Required]
    public decimal Price { get; set; }
    [Required]
    public int? CategoryId { get; set; }
    [Required]
    public IFormFile MainImage { get; set; } = null!;
    [Required]
    public IEnumerable<IFormFile> AdditionalImages { get; set; } = null!;
}
