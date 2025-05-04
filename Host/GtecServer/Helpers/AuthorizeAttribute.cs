using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace OzoneERP.Helpers
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorizeAttribute : Attribute, IAuthorizationFilter
    {

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var appSettings = "appsettings.json";
            IConfigurationBuilder builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile(appSettings, optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            var Token = configuration.GetSection("Token").GetSection("TokenDetails").Value;
           // skip authorization if action is decorated with [AllowAnonymous] attribute
           var allowAnonymous = context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any();
            if (allowAnonymous)
                return;
            var token = context.HttpContext.Items["token"];
            if (token.ToString() != Token.ToString())
            {
                //not logged in or role not authorized
               context.Result = new JsonResult(new { message = "Invalid Token", success = false }) { StatusCode = StatusCodes.Status401Unauthorized };
            }         

        }
    }
}
