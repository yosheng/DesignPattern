using BehaviorPattern.ChainOfResponsibilityPattern;
using Xunit.Abstractions;

namespace BehaviorPattern.Tests.ChainOfResponsibilityPattern;

public class ChainOfResponsibilityPatternTest : XunitContextBase
{
    public ChainOfResponsibilityPatternTest(ITestOutputHelper output) : base(output)
    {
    }

    [Fact]
    public void Test()
    {
        var director = new Director("张三");
        var manager = new Manager("李四");
        var administrator = new Administrator("王五");
        director.SetNext(manager);
        manager.SetNext(administrator);

        var approveData = new ApproveData
        {
            FlowName = "报销",
            FlowContent = "住宿",
            Price = 5200
        };        
        
        var approveData1 = new ApproveData
        {
            FlowName = "报销",
            FlowContent = "送礼",
            Price = 19999
        };
        
        var approveData2 = new ApproveData
        {
            FlowName = "报销",
            FlowContent = "车费",
            Price = 200
        };

        director.ProcessApproveData(approveData);
        director.ProcessApproveData(approveData1);
        director.ProcessApproveData(approveData2);
    }
}