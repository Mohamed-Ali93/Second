using Microsoft.Extensions.Localization;
using Second.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Second;

[Dependency(ReplaceServices = true)]
public class SecondBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<SecondResource> _localizer;

    public SecondBrandingProvider(IStringLocalizer<SecondResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
