using tokenAuth.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace tokenAuth.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(tokenAuthEntityFrameworkCoreModule),
    typeof(tokenAuthApplicationContractsModule)
    )]
public class tokenAuthDbMigratorModule : AbpModule
{

}
