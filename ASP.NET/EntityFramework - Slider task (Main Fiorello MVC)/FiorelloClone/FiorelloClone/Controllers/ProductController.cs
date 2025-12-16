using FiorelloClone.Data;
using FiorelloClone.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FiorelloClone.Controllers;

public class ProductController : Controller
{
    private readonly AppDbContext _context;
    public ProductController(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index()
    {
        IEnumerable<Product> products = await _context.Products
            .Include(m => m.ProductImages)
            .Include(m => m.Category)
            .Take(4)
            .Skip(4)
            .Where(m => !m.IsDeleted)
            .ToListAsync();
        return View(products);
    }
}
