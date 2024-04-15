using CreatePattern.FactoryMethodPattern;

namespace CreatePattern.Tests.FactoryMethodPattern;

public class AdminRoleFactoryTest
{
    [Fact]
    public void Test()
    {
        var roleFactory = new AdminRoleFactory();
        var role = roleFactory.CreateRole();
        Assert.Equal(0, role?.GetPermissionNumber());
        Assert.True(role?.IsSuperPower() ?? false);
    }
}