using AutoMapper;
using IdentityProjectAPI.Filters;
using IdentityProjectAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityProjectAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class AccountController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly UserManager<User> _userManager;

    public AccountController(IMapper mapper, UserManager<User> userManager)
    {
        _mapper = mapper;
        _userManager = userManager;
    }

    /// <summary>
    /// Register user
    /// </summary>
    /// <param name="userModel"></param>
    /// <returns></returns>
    [HttpPost("register")]
    [ApiValidationFilter]
    [AllowAnonymous]
    public async Task<IActionResult> Register(UserRegistrationModel userModel)
    {
        var user = _mapper.Map<User>(userModel);

        var result = await _userManager.CreateAsync(user, userModel.Password);
        if (!result.Succeeded)
        {
            return BadRequest(result.Errors);
        }

        await _userManager.AddToRoleAsync(user, "Visitor");

        return Ok("Registration successful");
    }

}

