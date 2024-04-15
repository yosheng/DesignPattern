using CreatePattern.AbstractFactoryPattern;

namespace CreatePattern.Tests.AbstractFactoryPattern;

public class PostgresRoleFactoryTest
{
    [Fact]
    public void Test()
    {
        var roleFactory = new PostgresRoleFactory();
        var role = roleFactory.CreateAdminRole();
        Assert.Equal(20, role.GetPermissionNumber());
        Assert.True(role?.IsSuperPower() ?? false);
    }
}