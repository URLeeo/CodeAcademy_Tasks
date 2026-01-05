using System.ComponentModel.DataAnnotations;

namespace Fruitables.Areas.Admin.ViewModels.SliderVMs;

public class CreateSliderVM
{
    [Required]
    public IFormFile Photo { get; set; } = null!;
}
