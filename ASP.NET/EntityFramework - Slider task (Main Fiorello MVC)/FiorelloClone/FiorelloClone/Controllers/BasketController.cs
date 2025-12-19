using FiorelloClone.ViewModels.BasketVMs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FiorelloClone.Controllers;

public class BasketController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> Add(int id)
    {
        List<BasketVM> basketVMs;

        var cookie = HttpContext.Request.Cookies["basket"];
        if (!string.IsNullOrWhiteSpace(cookie))
            basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(cookie) ?? new List<BasketVM>();
        else
            basketVMs = new List<BasketVM>();

        var exist = basketVMs.FirstOrDefault(x => x.Id == id);

        if (exist != null)
            exist.Count++;
        else
            basketVMs.Add(new BasketVM { Id = id, Count = 1 });

        HttpContext.Response.Cookies.Append("basket", JsonConvert.SerializeObject(basketVMs));

        return RedirectToAction("Index", "Home");
    }

}
