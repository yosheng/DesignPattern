using StructurePattern.ProxyPattern;
using Xunit.Abstractions;

namespace StructurePattern.Tests.ProxyPattern;

public class ProxyThirdPartyManagerTest : StructurePatternTestBase
{
    [Fact]
    public void Test()
    {
        IThirdPartyManager proxy = new ProxyThirdPartyManager();
        proxy.GetData("测试数据");
    }

    public ProxyThirdPartyManagerTest(ITestOutputHelper output) : base(output)
    {
    }
}