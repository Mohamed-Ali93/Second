using Volo.Abp.Modularity;

namespace Second;

public abstract class SecondApplicationTestBase<TStartupModule> : SecondTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
