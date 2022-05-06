using Microsoft.AspNetCore.Mvc;

namespace Begonia.Controllers;

public class AuthController : Controller
{
    public IActionResult Login()
    {
        throw new NotImplementedException();
    }

    public IActionResult Register()
    {
        return View();
    }
}