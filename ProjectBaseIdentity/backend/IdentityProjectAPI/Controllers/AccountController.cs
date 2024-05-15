using IdentityProjectAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace IdentityProjectAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class AccountController : Controller
{
    [HttpPost]
    public async Task<IActionResult> Register(UserRegistrationModel model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return Ok("Registration successful");
    }

}

