using Volo.Abp.Reflection;

namespace Test.Permissions;

public class TestPermissions
{
    public const string GroupName = "Test";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(TestPermissions));
    }
}
