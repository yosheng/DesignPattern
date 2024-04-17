using CreatePattern.PrototypePattern;

namespace CreatePattern.Tests.PrototypePattern;

public class ContractDetailTest
{
    [Fact]
    public void TestClone()
    {
        var contractDetail = new ContractDetail
        {
            Name = "合同1",
            Owner = "张三",
            Signatory = "李四",
            Terms = new List<string>
            {
                "1. 合同期限：一年",
                "2. 合同金额：100万"
            }
        };

        var clone = contractDetail.Clone() as ContractDetail;
        clone!.Signatory = "王五";
        clone!.Terms[0] = "1. 合同期限：两年";
        Assert.NotEqual(contractDetail.Terms[0], clone.Terms[0]);
        Assert.False(object.ReferenceEquals(contractDetail.Terms, clone.Terms));
    }
}