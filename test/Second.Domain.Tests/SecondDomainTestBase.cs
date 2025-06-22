using Volo.Abp.Modularity;

namespace Second;

/* Inherit from this class for your domain layer tests. */
public abstract class SecondDomainTestBase<TStartupModule> : SecondTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
