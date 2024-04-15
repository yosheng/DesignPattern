using CreatePattern.SimpleFactoryPattern;

namespace CreatePattern.AbstractFactoryPattern.SqlServer;

public class SqlServerAdminRole : IRole
{
    public int? GetPermissionNumber()
    {
        return 10;
    }

    public bool IsSuperPower()
    {
        return true;
    }
}