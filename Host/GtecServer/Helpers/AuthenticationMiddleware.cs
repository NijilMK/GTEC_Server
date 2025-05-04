using System.Security.Claims;
using System.Text;

namespace OzoneERP.Helpers
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;

        public JwtMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context )
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (token == null)
            {
                context.Items["token"] = "";
            }
            else
            {
                context.Items["token"] = token.Trim();
            }
            
            await _next(context);
        }
    }
}
