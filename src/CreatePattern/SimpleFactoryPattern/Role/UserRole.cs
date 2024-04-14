namespace CreatePattern.SimpleFactoryPattern.Role;

public class UserRole : IRole
{
    public int? GetPermissionNumber()
    {
        return 2;
    }

    public bool IsSuperPower()
    {
        return false;
    }
}