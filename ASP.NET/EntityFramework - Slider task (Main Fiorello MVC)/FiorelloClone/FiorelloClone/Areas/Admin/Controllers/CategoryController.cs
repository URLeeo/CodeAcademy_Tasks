using FiorelloClone.Areas.Admin.ViewModels.CategoryVMs;
using FiorelloClone.Data;
using FiorelloClone.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FiorelloClone.Areas.Admin.Controllers;

[Area("Admin")]
public class CategoryController : Controller
{
    private readonly AppDbContext _context;
    public CategoryController(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index()
    {
        IEnumerable<Category> categories = await _context.Categories.OrderByDescending(m => m.Id).Where(c => !c.IsDeleted).ToListAsync();

        IEnumerable<GetAllCategoryVM> getAllCategoryVMs = categories.Select(category => new GetAllCategoryVM
        {
            Name = category.Name
        });

        return View(getAllCategoryVMs);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Category category)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        bool isExist = await _context.Categories.AnyAsync(c => c.Name.ToLower().Trim() == category.Name.ToLower().Trim());
        if (isExist)
        {
            ModelState.AddModelError("Name", "This category already exists");
            return View();
        }
        await _context.Categories.AddAsync(category);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
}
