using Second.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Second.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SecondController : AbpControllerBase
{
    protected SecondController()
    {
        LocalizationResource = typeof(SecondResource);
    }
}
