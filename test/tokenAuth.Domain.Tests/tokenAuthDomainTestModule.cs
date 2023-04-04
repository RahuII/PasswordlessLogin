using tokenAuth.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace tokenAuth;

[DependsOn(
    typeof(tokenAuthEntityFrameworkCoreTestModule)
    )]
public class tokenAuthDomainTestModule : AbpModule
{

}
