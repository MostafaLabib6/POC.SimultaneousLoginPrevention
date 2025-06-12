using Microsoft.Extensions.Localization;
using OCR.SimultaniousLogin.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace OCR.SimultaniousLogin;

[Dependency(ReplaceServices = true)]
public class SimultaniousLoginBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<SimultaniousLoginResource> _localizer;

    public SimultaniousLoginBrandingProvider(IStringLocalizer<SimultaniousLoginResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
