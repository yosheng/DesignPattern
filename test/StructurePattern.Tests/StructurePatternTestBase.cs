using Xunit.Abstractions;

namespace StructurePattern.Tests;

public class StructurePatternTestBase
{
    public StructurePatternTestBase(ITestOutputHelper output)
    {
        var converter = new Converter(output);
        Console.SetOut(converter);
    }
}