using CreatePattern.SimpleFactoryPattern;

namespace CreatePattern.Tests.SimpleFactoryPattern;

public class RoleManagerTest
{
    [Fact]
    public void Test()
    {
        var roleManager = new RoleManager("admin");
        Assert.Equal(0, roleManager.GetPermissionNumber());
        Assert.True(roleManager.IsSuperPower());
    }
}