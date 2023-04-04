using System.Threading.Tasks;

namespace tokenAuth.Data;

public interface ItokenAuthDbSchemaMigrator
{
    Task MigrateAsync();
}
