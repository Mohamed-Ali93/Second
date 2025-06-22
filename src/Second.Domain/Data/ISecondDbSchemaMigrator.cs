using System.Threading.Tasks;

namespace Second.Data;

public interface ISecondDbSchemaMigrator
{
    Task MigrateAsync();
}
