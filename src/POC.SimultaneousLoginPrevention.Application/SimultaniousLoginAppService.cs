using System;
using System.Collections.Generic;
using System.Text;
using OCR.SimultaniousLogin.Localization;
using Volo.Abp.Application.Services;

namespace OCR.SimultaniousLogin;

/* Inherit your application services from this class.
 */
public abstract class SimultaniousLoginAppService : ApplicationService
{
    protected SimultaniousLoginAppService()
    {
        LocalizationResource = typeof(SimultaniousLoginResource);
    }
}
