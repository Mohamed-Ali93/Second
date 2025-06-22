using Xunit;

namespace Second.EntityFrameworkCore;

[CollectionDefinition(SecondTestConsts.CollectionDefinitionName)]
public class SecondEntityFrameworkCoreCollection : ICollectionFixture<SecondEntityFrameworkCoreFixture>
{

}
