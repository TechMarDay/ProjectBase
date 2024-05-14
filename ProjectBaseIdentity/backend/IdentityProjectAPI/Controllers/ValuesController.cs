using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IdentityProjectAPI.Controllers;
[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class ValuesController : ControllerBase
{

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok("test");
    }
}
