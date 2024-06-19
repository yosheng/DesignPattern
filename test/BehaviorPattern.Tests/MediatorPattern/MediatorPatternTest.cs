using BehaviorPattern.MediatorPattern;
using BehaviorPattern.MediatorPattern.Role;
using Xunit.Abstractions;

namespace BehaviorPattern.Tests.MediatorPattern;

public class MediatorPatternTest : XunitContextBase
{
    public MediatorPatternTest(ITestOutputHelper output) : base(output)
    {
    }

    [Fact]
    public void Test()
    {
        var roleMediator = new RoleMediator();
        roleMediator.Leader = new Leader(roleMediator);
        roleMediator.Doctor = new Doctor(roleMediator);
        roleMediator.Nurse = new Nurse(roleMediator);
        
        roleMediator.Leader.Prepare();
    }
}