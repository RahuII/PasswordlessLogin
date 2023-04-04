using Volo.Abp.Modularity;

namespace tokenAuth;

[DependsOn(
    typeof(tokenAuthApplicationModule),
    typeof(tokenAuthDomainTestModule)
    )]
public class tokenAuthApplicationTestModule : AbpModule
{

}
