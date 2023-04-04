using tokenAuth.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace tokenAuth.Permissions;

public class tokenAuthPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(tokenAuthPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(tokenAuthPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<tokenAuthResource>(name);
    }
}
