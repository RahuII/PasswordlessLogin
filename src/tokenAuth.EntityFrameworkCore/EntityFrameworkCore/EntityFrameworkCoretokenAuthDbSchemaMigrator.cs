using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using tokenAuth.Data;
using Volo.Abp.DependencyInjection;

namespace tokenAuth.EntityFrameworkCore;

public class EntityFrameworkCoretokenAuthDbSchemaMigrator
    : ItokenAuthDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoretokenAuthDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the tokenAuthDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<tokenAuthDbContext>()
            .Database
            .MigrateAsync();
    }
}
