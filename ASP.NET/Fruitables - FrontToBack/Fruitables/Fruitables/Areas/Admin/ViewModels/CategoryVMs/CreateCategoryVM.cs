using System.ComponentModel.DataAnnotations;

namespace Fruitables.Areas.Admin.ViewModels.CategoryVMs;

public class CreateCategoryVM
{
    [Required]
    public string Name { get; set; }
}
