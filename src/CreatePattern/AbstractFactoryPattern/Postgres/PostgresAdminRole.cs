using CreatePattern.SimpleFactoryPattern;

namespace CreatePattern.AbstractFactoryPattern.Postgres;

public class PostgresAdminRole : IRole
{
    public int? GetPermissionNumber()
    {
        return 20;
    }

    public bool IsSuperPower()
    {
        return true;
    }
}