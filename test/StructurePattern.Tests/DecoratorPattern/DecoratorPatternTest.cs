using StructurePattern.DecoratorPattern;
using StructurePattern.DecoratorPattern.Decorator;
using Xunit.Abstractions;

namespace StructurePattern.Tests.DecoratorPattern;

public class DecoratorPatternTest : StructurePatternTestBase
{
    [Fact]
    public void Test()
    {
        var logic = new Logic("select * from table");
        var departmentDecorator = new DepartmentDecorator(logic);
        var trendDecorator = new TrendDecorator(logic);
        
        _output.WriteLine(departmentDecorator.PreviewSql());
        Assert.NotEmpty(departmentDecorator.PreviewSql());
        
        _output.WriteLine(trendDecorator.PreviewSql());
        Assert.NotEmpty(trendDecorator.PreviewSql());
    }

    public DecoratorPatternTest(ITestOutputHelper output) : base(output)
    {
    }
}