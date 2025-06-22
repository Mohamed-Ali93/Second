using Second.Samples;
using Xunit;

namespace Second.EntityFrameworkCore.Domains;

[Collection(SecondTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<SecondEntityFrameworkCoreTestModule>
{

}
