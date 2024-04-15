using CreatePattern.SimpleFactoryPattern;

namespace CreatePattern.AbstractFactoryPattern.SqlServer;

public class SqlServerSystemRole : IRole
{
    public int? GetPermissionNumber()
    {
        return 11;
    }

    public bool IsSuperPower()
    {
        return true;
    }
}