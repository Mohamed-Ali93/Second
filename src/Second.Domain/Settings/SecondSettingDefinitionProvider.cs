using Volo.Abp.Settings;

namespace Second.Settings;

public class SecondSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SecondSettings.MySetting1));
    }
}
