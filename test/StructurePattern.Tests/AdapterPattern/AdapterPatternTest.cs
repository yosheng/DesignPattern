using StructurePattern.AdapterPattern.Scenario1.Service;
using StructurePattern.AdapterPattern.Scenario2;
using StructurePattern.AdapterPattern.Scenario2.User;
using Xunit.Abstractions;

namespace StructurePattern.Tests.AdapterPattern;

public class AdapterPatternTest
{
    public AdapterPatternTest(ITestOutputHelper output)
    {
        var converter = new Converter(output);
        Console.SetOut(converter);
    }
    
    [Fact]
    public void Scenario1_Test()
    {
        var reportService = new ReportService();
        
        reportService.GetNotification();
    }
    
    [Fact]
    public void Scenario2_Test()
    {
        var dingDingSender = new DingDingSender();
        var wechatSender = new WechatSender();

        var personalUser = new PersonalUser(wechatSender);
        var companyUser = new CompanyUser(dingDingSender);

        personalUser.SendMessage("测试消息");
        companyUser.SendMessage("测试消息");
    }
}