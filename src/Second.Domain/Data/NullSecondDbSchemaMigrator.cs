using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Second.Data;

/* This is used if database provider does't define
 * ISecondDbSchemaMigrator implementation.
 */
public class NullSecondDbSchemaMigrator : ISecondDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
