using OCR.SimultaniousLogin.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace OCR.SimultaniousLogin.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SimultaniousLoginController : AbpControllerBase
{
    protected SimultaniousLoginController()
    {
        LocalizationResource = typeof(SimultaniousLoginResource);
    }
}
