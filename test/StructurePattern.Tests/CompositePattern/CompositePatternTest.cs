using StructurePattern.CompositePattern.Scenario1;
using StructurePattern.CompositePattern.Scenario2;
using Xunit.Abstractions;

namespace StructurePattern.Tests.CompositePattern;

public class CompositePatternTest : StructurePatternTestBase
{
    public CompositePatternTest(ITestOutputHelper output) : base(output)
    {
    }

    /// <summary>
    /// 透明组合模式
    /// </summary>
    [Fact]
    public void Scenario1_Test()
    {
        var compositeGroup = new CompositeGroup("上海医院", "SHH");
        compositeGroup.Add(new DepartmentItem("骨科", "GK"));
        compositeGroup.Add(new DepartmentItem("产科", "CK"));
        compositeGroup.Add(new DepartmentItem("神经科", "SJK"));
        compositeGroup.Add(new WardItem("骨A区", "GAQ"));
        compositeGroup.Add(new WardItem("产B区", "CBQ"));
        
        compositeGroup.Operation();
    }
    
    /// <summary>
    /// 安全组合模式
    /// </summary>
    [Fact]
    public void Scenario2_Test()
    {
        var root = new CompositeTree("root");
        root.Add(new Leaf("Leaf A"));
        root.Add(new Leaf("Leaf B"));
 
        var com = new CompositeTree("Com X");
        com.Add(new Leaf("LeafX A"));
        com.Add(new Leaf("LeafX B"));
 
        root.Add(com);
 
        var com2 = new CompositeTree("Com XY");
        com.Add(new Leaf("LeafXY A"));
        com.Add(new Leaf("LeafXY B"));
        com.Add(com2);
 
        root.Display(1);
    }
}