using Microsoft.AspNetCore.Builder;
using OCR.SimultaniousLogin.Middlewares;

namespace OCR.SimultaniousLogin.Extensions
{
    public static class ConcurrentLoginValidationExtentions
    {
        public static IApplicationBuilder UseConcurrentLoginValidation(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ConcurrentLoginValidationMiddleware>();
        }
    }
}
