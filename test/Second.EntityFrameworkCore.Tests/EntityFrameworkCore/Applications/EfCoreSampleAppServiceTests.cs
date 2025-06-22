using Second.Samples;
using Xunit;

namespace Second.EntityFrameworkCore.Applications;

[Collection(SecondTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<SecondEntityFrameworkCoreTestModule>
{

}
