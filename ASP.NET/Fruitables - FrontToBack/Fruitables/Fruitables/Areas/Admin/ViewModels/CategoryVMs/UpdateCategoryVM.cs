using System.ComponentModel.DataAnnotations;

namespace Fruitables.Areas.Admin.ViewModels.CategoryVMs;

public class UpdateCategoryVM
{
    [Required]
    public string Name { get; set; }
}
