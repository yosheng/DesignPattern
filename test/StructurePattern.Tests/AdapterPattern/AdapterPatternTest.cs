using StructurePattern.AdapterPattern.Scenario1.Service;
using StructurePattern.AdapterPattern.Scenario2;
using StructurePattern.AdapterPattern.Scenario2.China;
using StructurePattern.AdapterPattern.Scenario2.Taiwan;
using Xunit.Abstractions;

namespace StructurePattern.Tests.AdapterPattern;

public class AdapterPatternTest : StructurePatternTestBase
{
    [Fact]
    public void Scenario1_Test()
    {
        var reportService = new ReportService();

        reportService.GetNotification();
    }
    
    [Fact]
    public void Scenario2_Test()
    {
        ICharge charge = new TaiwanAdapter();
        charge.Request();        
        
        charge = new ChinaAdapter();
        charge.Request();
    }

    public AdapterPatternTest(ITestOutputHelper output) : base(output)
    {
    }
}