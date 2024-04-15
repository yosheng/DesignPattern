using CreatePattern.SimpleFactoryPattern;

namespace CreatePattern.AbstractFactoryPattern.SqlServer;

public class SqlServerUserRole : IRole
{
    public int? GetPermissionNumber()
    {
        return 12;
    }

    public bool IsSuperPower()
    {
        return false;
    }
}