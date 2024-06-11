using Microsoft.AspNetCore.Mvc;

namespace FirstWork.Controllers;

public class AccountController : TodoBaseController
{
    public IActionResult Index()
    {
        // ReSharper disable once Mvc.ViewNotResolved
        return View();
    }


    public IActionResult Login()
    {
        throw new NotImplementedException();
    }

    public IActionResult Register()
    {
        throw new NotImplementedException();
    }
}