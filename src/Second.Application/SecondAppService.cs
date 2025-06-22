using Second.Localization;
using Volo.Abp.Application.Services;

namespace Second;

/* Inherit your application services from this class.
 */
public abstract class SecondAppService : ApplicationService
{
    protected SecondAppService()
    {
        LocalizationResource = typeof(SecondResource);
    }
}
