using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.IdentityModel.Tokens;
using ProjectBaseIdentity.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace ProjectBaseIdentity.Controllers;

[Route("api/authen")]
[ApiController]
public class AuthenController : ControllerBase
{
    private readonly IConfiguration _config;
    public AuthenController(IConfiguration config)
    {
        _config = config;
    }

    /// <summary>
    /// Generate token
    /// </summary>
    /// <param name="tokenModel"></param>
    /// <returns>return valid token</returns>
    [AllowAnonymous]
    [HttpPost]
    [Route("generate-token")]
    //public async Task<IActionResult> GenerateToken(UserLoginModel tokenModel)
    //{
    //    var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);

    //    //Add claims
    //    var token = GetAccessToken(identity);
    //    return Ok(token);
    //}

    private string GetAccessToken(ClaimsIdentity claimsIdentity)
    {
        try
        {
            var keyByteArray = WebEncoders.Base64UrlDecode(_config["IssuerSecretKey"]);
            var signingKey = new SigningCredentials(new SymmetricSecurityKey(keyByteArray), SecurityAlgorithms.HmacSha256Signature);

            var issued = DateTimeOffset.UtcNow;
            var expires = DateTimeOffset.UtcNow.AddDays(1);

            var token = new JwtSecurityToken(_config["Issuer"], _config["ClientId"], claimsIdentity.Claims, issued.UtcDateTime, expires.UtcDateTime, signingKey);

            var handler = new JwtSecurityTokenHandler();

            return handler.WriteToken(token);

        }
        catch (Exception ex)
        {
            return string.Empty;
        }
    }
}
