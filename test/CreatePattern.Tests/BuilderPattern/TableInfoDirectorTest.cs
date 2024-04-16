using CreatePattern.BuilderPattern;
using CreatePattern.BuilderPattern.Builder;

namespace CreatePattern.Tests.BuilderPattern;

public class TableInfoDirectorTest
{
    [Fact]
    public void Test()
    {
        var tableInfoDirector = new TableInfoDirector();
        var userTableInfoBuilder = new UserTableInfoBuilder();
        var constructQuerySql = tableInfoDirector.ConstructQuerySql(userTableInfoBuilder);
        Assert.Equal("select * from User order by Id desc", constructQuerySql);
    }
}