using Xunit.Abstractions;

namespace StructurePattern.Tests;

public class StructurePatternTestBase
{
    protected readonly ITestOutputHelper _output;
    
    public StructurePatternTestBase(ITestOutputHelper output)
    {
        _output = output;
        var converter = new Converter(output);
        Console.SetOut(converter);
    }
}