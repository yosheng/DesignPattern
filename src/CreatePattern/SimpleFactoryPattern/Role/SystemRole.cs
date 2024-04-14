namespace CreatePattern.SimpleFactoryPattern.Role;

public class SystemRole : IRole
{
    public int? GetPermissionNumber()
    {
        return 1;
    }

    public bool IsSuperPower()
    {
        return true;
    }
}