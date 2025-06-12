using OCR.SimultaniousLogin.Localization;
using Volo.Abp.AspNetCore.Components;

namespace OCR.SimultaniousLogin.Blazor.Client;

public abstract class SimultaniousLoginComponentBase : AbpComponentBase
{
    protected SimultaniousLoginComponentBase()
    {
        LocalizationResource = typeof(SimultaniousLoginResource);
    }
}
