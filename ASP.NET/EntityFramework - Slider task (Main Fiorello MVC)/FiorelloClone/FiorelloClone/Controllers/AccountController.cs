using FiorelloClone.Models;
using FiorelloClone.ViewModels.AccountVMs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;

namespace FiorelloClone.Controllers;

public class AccountController : Controller
{
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;

    public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Register(RegisterVM request)
    {
        if (!ModelState.IsValid) return View(request);

        AppUser appUser = new()
        {
            Name = request.Name,
            Surname = request.Surname,
            UserName = request.Username,
            Email = request.Email
        };

        IdentityResult result = await _userManager.CreateAsync(appUser, request.Password);
        if (!result.Succeeded)
        {
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return View(request);
        }

        //await _signInManager.SignInAsync(appUser, isPersistent: false);

        return RedirectToAction("Index", "Home");
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(LoginVM request)
    {
        if (!ModelState.IsValid) return View(request);
        AppUser? appUser = await _userManager.FindByNameAsync(request.UsernameOrEmail);
        if (appUser == null)
        {
            appUser = await _userManager.FindByEmailAsync(request.UsernameOrEmail);
            if (appUser == null)
            {
                ModelState.AddModelError(string.Empty, "Username, email or password is incorrect!");
                return View(request);
            }
        }

        var signInResult = await _signInManager.PasswordSignInAsync(appUser, request.Password, false, false);
        if (!signInResult.Succeeded)
        {
            ModelState.AddModelError(string.Empty, "Username, email or password is incorrect!");
            return View(request);
        }
        else
        {
            await _signInManager.SignInAsync(appUser, false);
        }
        return RedirectToAction("Index", "Home");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        return RedirectToAction("Index", "Home");
    }
}
