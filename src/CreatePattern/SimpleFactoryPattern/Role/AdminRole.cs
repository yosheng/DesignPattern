namespace CreatePattern.SimpleFactoryPattern.Role;

public class AdminRole : IRole
{
    public int? GetPermissionNumber()
    {
        return 0;
    }

    public bool IsSuperPower()
    {
        return true;
    }
}