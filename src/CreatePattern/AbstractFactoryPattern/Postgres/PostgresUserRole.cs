using CreatePattern.SimpleFactoryPattern;

namespace CreatePattern.AbstractFactoryPattern.Postgres;

public class PostgresUserRole : IRole
{
    public int? GetPermissionNumber()
    {
        return 22;
    }

    public bool IsSuperPower()
    {
        return false;
    }
}