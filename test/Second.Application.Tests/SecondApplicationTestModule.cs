using Volo.Abp.Modularity;

namespace Second;

[DependsOn(
    typeof(SecondApplicationModule),
    typeof(SecondDomainTestModule)
)]
public class SecondApplicationTestModule : AbpModule
{

}
