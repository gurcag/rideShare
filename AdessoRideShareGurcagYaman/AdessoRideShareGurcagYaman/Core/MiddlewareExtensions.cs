using Microsoft.AspNetCore.Builder;

namespace AdessoRideShareGurcagYaman.Core
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionHandler>();
        }
    }
}
