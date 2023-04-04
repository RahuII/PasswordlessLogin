using tokenAuth.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace tokenAuth.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class tokenAuthController : AbpControllerBase
{
    protected tokenAuthController()
    {
        LocalizationResource = typeof(tokenAuthResource);
    }
}
