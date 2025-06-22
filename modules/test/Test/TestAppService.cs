using Test.Localization;
using Volo.Abp.Application.Services;

namespace Test;

public abstract class TestAppService : ApplicationService
{
    protected TestAppService()
    {
        LocalizationResource = typeof(TestResource);
        ObjectMapperContext = typeof(TestModule);
    }
}
