using BehaviorPattern.VisitorPattern;
using BehaviorPattern.VisitorPattern.Element;
using BehaviorPattern.VisitorPattern.Visit;
using Xunit.Abstractions;

namespace BehaviorPattern.Tests.VisitorPattern;

public class VisitorPatternTest : XunitContextBase
{
    public VisitorPatternTest(ITestOutputHelper output) : base(output)
    {
    }
    
    [Fact]
    public void Test()
    {
        var hospitalStructure = new HospitalStructure();
        hospitalStructure.Add(new DoctorElement("张三", 100));
        hospitalStructure.Add(new NurseElement("小花", 80));
        
        hospitalStructure.Accept(new HumanResourceVisitor());
        
        hospitalStructure.Accept(new FinanceVisitor());
    }
}