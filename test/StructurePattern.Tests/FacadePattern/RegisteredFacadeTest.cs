using StructurePattern.FacadePattern;
using Xunit.Abstractions;

namespace StructurePattern.Tests.FacadePattern;

public class RegisteredFacadeTest : StructurePatternTestBase
{
    [Fact]
    public void Test()
    {
        var registeredFacade = new RegisteredFacade();
        registeredFacade.Register("张三");
    }

    public RegisteredFacadeTest(ITestOutputHelper output) : base(output)
    {
    }
}