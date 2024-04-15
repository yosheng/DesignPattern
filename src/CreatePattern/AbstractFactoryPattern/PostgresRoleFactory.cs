using CreatePattern.AbstractFactoryPattern.Postgres;
using CreatePattern.SimpleFactoryPattern;

namespace CreatePattern.AbstractFactoryPattern;

public class PostgresRoleFactory : IDatabaseRoleFactory
{
    public IRole CreateAdminRole()
    {
        return new PostgresAdminRole();
    }

    public IRole CreateSystemRole()
    {
        return new PostgresSystemRole();
    }

    public IRole CreateUserRole()
    {
        return new PostgresUserRole();
    }
}