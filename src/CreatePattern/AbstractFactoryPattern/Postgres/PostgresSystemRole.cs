using CreatePattern.SimpleFactoryPattern;

namespace CreatePattern.AbstractFactoryPattern.Postgres;

public class PostgresSystemRole : IRole
{
    public int? GetPermissionNumber()
    {
        return 21;
    }

    public bool IsSuperPower()
    {
        return true;
    }
}