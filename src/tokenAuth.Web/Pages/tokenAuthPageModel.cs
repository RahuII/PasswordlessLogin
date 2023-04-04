using tokenAuth.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace tokenAuth.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class tokenAuthPageModel : AbpPageModel
{
    protected tokenAuthPageModel()
    {
        LocalizationResourceType = typeof(tokenAuthResource);
    }
}
