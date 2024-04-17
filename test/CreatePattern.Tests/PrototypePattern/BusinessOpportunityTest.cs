using CreatePattern.PrototypePattern;

namespace CreatePattern.Tests.PrototypePattern;

public class BusinessOpportunityTest
{
    [Fact]
    public void TestClone()
    {
        var businessOpportunity = new BusinessOpportunity
        {
            Zone = "上海",
            Owner = "Sam"
        };

        var clone = (BusinessOpportunity)businessOpportunity.Clone();
        clone.Zone = "台湾";
        
        Assert.NotEqual(businessOpportunity.Zone, clone.Zone);
        Assert.False(object.ReferenceEquals(businessOpportunity, clone));
    }
}