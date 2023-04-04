using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace tokenAuth.Web;

[Dependency(ReplaceServices = true)]
public class tokenAuthBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "tokenAuth";
}
