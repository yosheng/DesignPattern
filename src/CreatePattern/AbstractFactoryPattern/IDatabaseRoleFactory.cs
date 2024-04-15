using CreatePattern.SimpleFactoryPattern;

namespace CreatePattern.AbstractFactoryPattern;

public interface IDatabaseRoleFactory
{
    IRole CreateAdminRole();
    
    IRole CreateSystemRole();
    
    IRole CreateUserRole();
}