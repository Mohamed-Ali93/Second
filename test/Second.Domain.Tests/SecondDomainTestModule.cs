using Volo.Abp.Modularity;

namespace Second;

[DependsOn(
    typeof(SecondDomainModule),
    typeof(SecondTestBaseModule)
)]
public class SecondDomainTestModule : AbpModule
{

}
