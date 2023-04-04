using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace tokenAuth.Data;

/* This is used if database provider does't define
 * ItokenAuthDbSchemaMigrator implementation.
 */
public class NulltokenAuthDbSchemaMigrator : ItokenAuthDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
