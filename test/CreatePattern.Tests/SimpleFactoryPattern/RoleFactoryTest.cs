using CreatePattern.SimpleFactoryPattern;

namespace CreatePattern.Tests.SimpleFactoryPattern;

public class RoleFactoryTest
{
    [Fact]
    public void Test()
    {
        var role = RoleFactory.CreateRole("admin");
        Assert.Equal(0, role?.GetPermissionNumber());
        Assert.True(role?.IsSuperPower() ?? false);
    }
}