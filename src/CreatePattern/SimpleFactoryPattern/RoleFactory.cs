using CreatePattern.SimpleFactoryPattern.Role;

namespace CreatePattern.SimpleFactoryPattern;

public static class RoleFactory
{
    public static IRole? CreateRole(string type)
    {
        switch (type)
        {
            case "admin":
                return new AdminRole();
            case "system":
                return new SystemRole();
            case "user":
                return new UserRole();
            default:
                return null;
        }
    }
}

public interface IRole
{
    int? GetPermissionNumber();

    bool IsSuperPower();
}