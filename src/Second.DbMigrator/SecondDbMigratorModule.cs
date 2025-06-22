using Second.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Second.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SecondEntityFrameworkCoreModule),
    typeof(SecondApplicationContractsModule)
)]
public class SecondDbMigratorModule : AbpModule
{
}
