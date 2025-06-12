using Volo.Abp.Settings;

namespace OCR.SimultaniousLogin.Settings;

public class SimultaniousLoginSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SimultaniousLoginSettings.MySetting1));
    }
}
