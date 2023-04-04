using Volo.Abp.Settings;

namespace tokenAuth.Settings;

public class tokenAuthSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(tokenAuthSettings.MySetting1));
    }
}
