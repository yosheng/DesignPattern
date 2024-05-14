using BehaviorPattern.TemplateMethodPattern;
using Xunit.Abstractions;

namespace BehaviorPattern.Tests.TemplateMethodPattern;

public class TemplateMethodPatternTest : XunitContextBase
{
    public TemplateMethodPatternTest(ITestOutputHelper output) : base(output)
    {
    }
    
    [Fact]
    public void Test()
    {
        var doctor = new Doctor("张三");
        doctor.GoOff();
        
        var nurse = new Nurse("小花");
        nurse.GoOff();
    }
}