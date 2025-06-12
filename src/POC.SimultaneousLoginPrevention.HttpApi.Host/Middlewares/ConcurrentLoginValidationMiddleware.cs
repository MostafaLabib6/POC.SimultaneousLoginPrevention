using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Volo.Abp.Identity;
using Volo.Abp.Users;
using ConcurrentLogin;
using Volo.Abp.Data;
using Volo.Abp.Identity.AspNetCore;

namespace OCR.SimultaniousLogin.Middlewares
{
    public class ConcurrentLoginValidationMiddleware
    {
        public RequestDelegate _next;

        public ConcurrentLoginValidationMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            var currentUser = httpContext.RequestServices.GetRequiredService<ICurrentUser>();

            if (currentUser.IsAuthenticated)

            {

                var claimToken = currentUser.GetConcurrentLoginToken();

                var userManager = httpContext.RequestServices.GetRequiredService<IdentityUserManager>();

                var user = await userManager.FindByIdAsync(currentUser.Id.ToString());

                if (claimToken != user.GetProperty(SimultaniousLoginConsts.ConcurrentLoginToken).ToString())

                {

                    //Cookies

                    if (httpContext.User.Identity != null && httpContext.User.Identity.AuthenticationType == "Identity.Application")

                    {

                        await httpContext.RequestServices.GetRequiredService<AbpSignInManager>().SignOutAsync();

                        await httpContext.ChallengeAsync("Identity.Application");

                    }

                    //JWT

                    if (httpContext.User.Identity != null && httpContext.User.Identity.AuthenticationType == "AuthenticationTypes.Federation")

                    {

                        await httpContext.ChallengeAsync(JwtBearerDefaults.AuthenticationScheme);

                    }

                    //Other

                    return;

                }

            }

            await _next(httpContext);
        }
    }
}

