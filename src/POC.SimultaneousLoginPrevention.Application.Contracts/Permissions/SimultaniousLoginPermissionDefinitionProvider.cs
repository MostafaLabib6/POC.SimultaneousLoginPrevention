using OCR.SimultaniousLogin.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace OCR.SimultaniousLogin.Permissions;

public class SimultaniousLoginPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SimultaniousLoginPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SimultaniousLoginPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SimultaniousLoginResource>(name);
    }
}
