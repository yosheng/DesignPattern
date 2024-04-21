using StructurePattern.BridgePattern.Sender;
using StructurePattern.BridgePattern.User;
using Xunit.Abstractions;

namespace StructurePattern.Tests.BridgePattern;

public class BridgePatternTest : StructurePatternTestBase
{
        
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

    public BridgePatternTest(ITestOutputHelper output) : base(output)
    {
    }
}