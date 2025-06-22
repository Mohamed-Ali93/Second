using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Test.Data;

[ConnectionStringName(TestDbProperties.ConnectionStringName)]
public interface ITestDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
