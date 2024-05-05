using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectBaseIdentity.Models;

namespace ProjectBaseIdentity.Controllers;

[Route("account")]
public class AccountController : Controller
{
    //[HttpGet]
    //[AllowAnonymous]
    //[Route("login")]
    //public async Task<IActionResult> Login([FromQuery] string returnUrl, int errorCode = 0)
    //{
    //    if (HttpContext.User.Identity.IsAuthenticated)
    //    {
    //        if (string.IsNullOrEmpty(returnUrl))
    //        {
    //            return RedirectToAction("Index", "Home");
    //        }
    //        return RedirectPermanent(returnUrl ?? "/");
    //    }

    //    return View();
    //}

    //[HttpPost]
    //[Route("login")]
    //[ValidateAntiForgeryToken]
    //public async Task<IActionResult> Login([FromForm] UserLoginModel model)
    //{
    //    try
    //    {
    //        var returnUrl = Request.Form["returnUrl"].ToString();

    //        if (string.IsNullOrEmpty(returnUrl))
    //        {
    //            return RedirectToAction("Index", "Home");
    //        }

    //        return RedirectPermanent(returnUrl ?? "/");
    //    }
    //    catch (Exception ex)
    //    {
    //        return BadRequest(ex.Message);
    //    }
    //}
}
