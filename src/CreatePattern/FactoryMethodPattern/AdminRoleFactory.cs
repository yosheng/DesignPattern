using CreatePattern.SimpleFactoryPattern;
using CreatePattern.SimpleFactoryPattern.Role;

namespace CreatePattern.FactoryMethodPattern;

public class AdminRoleFactory : IRoleFactory
{
    public IRole? CreateRole()
    {
        return new AdminRole();
    }
}