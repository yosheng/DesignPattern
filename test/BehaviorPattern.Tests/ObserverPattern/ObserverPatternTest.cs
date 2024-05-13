using BehaviorPattern.ObserverPattern;
using Xunit.Abstractions;

namespace BehaviorPattern.Tests.ObserverPattern;

public class ObserverPatternTest : XunitContextBase
{
    public ObserverPatternTest(ITestOutputHelper output) : base(output)
    {
    }

    [Fact]
    public void Test()
    {
        var departmentSubject = new DepartmentSubject();
        departmentSubject.Register(new Doctor());
        departmentSubject.Register(new Nurse());
        
        departmentSubject.Notify("有患者刚来就诊！");
    }
}