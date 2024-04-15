using CreatePattern.AbstractFactoryPattern.SqlServer;
using CreatePattern.SimpleFactoryPattern;

namespace CreatePattern.AbstractFactoryPattern;

public class SqlServerRoleFactory : IDatabaseRoleFactory
{
    public IRole CreateAdminRole()
    {
        return new SqlServerAdminRole();
    }

    public IRole CreateSystemRole()
    {
        return new SqlServerSystemRole();
    }

    public IRole CreateUserRole()
    {
        return new SqlServerUserRole();
    }
}