using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Net;

namespace AdessoRideShareGurcagYaman.Core
{
    public class ExceptionHandler
    {
        private readonly RequestDelegate Next;

        public ExceptionHandler(RequestDelegate next)
        {
            Next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await Next.Invoke(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var response = context.Response;

            response.StatusCode = (int)HttpStatusCode.InternalServerError;

            await response.WriteAsync("Internal Server Error");
        }
    }
}
