namespace StructurePattern.FlyweightPattern;

// FlyweightFactory
public static class RoleJobFactory
{
    private static readonly Dictionary<string, IRoleJob> RoleJobs = new Dictionary<string, IRoleJob>();

    static RoleJobFactory()
    {
        RoleJobs.Add("Doctor", new Doctor());
        RoleJobs.Add("Nurse", new Nurse());
    }

    public static IRoleJob GetRoleJob(string roleName)
    {
        if (RoleJobs.ContainsKey(roleName))
        {
            return RoleJobs[roleName];
        }
        
        throw new Exception("Factory cannot create the object specified");
    }
}