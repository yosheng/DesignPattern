using StructurePattern.FlyweightPattern;
using Xunit.Abstractions;

namespace StructurePattern.Tests.FlyweightPattern;

public class RoleJobFactoryTest : StructurePatternTestBase
{
    [Fact]
    public void Test()
    {
        var doctor = RoleJobFactory.GetRoleJob("Doctor");
        doctor.Working("检查患者");
        var doctor1 = RoleJobFactory.GetRoleJob("Doctor");
        doctor1.Working("给患者开药物");
        var nurse = RoleJobFactory.GetRoleJob("Nurse");
        nurse.Working("照顾患者");
    }

    public RoleJobFactoryTest(ITestOutputHelper output) : base(output)
    {
    }
}