using IdentityProjectAPI.Helpers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace IdentityProjectAPI.Filters;

public class ApiValidationFilterAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        if (!context.ModelState.IsValid)
        {
            context.Result = new BadRequestObjectResult(new ApiBadRequestResponse(context.ModelState));
        }

        base.OnActionExecuting(context);
    }
}