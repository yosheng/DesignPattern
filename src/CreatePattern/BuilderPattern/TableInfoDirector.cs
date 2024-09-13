using CreatePattern.BuilderPattern.Builder;

namespace CreatePattern.BuilderPattern;

public class TableInfoDirector
{
    private TableInfo Construct(TableInfoBuilder tableInfoBuilder)
    {
        tableInfoBuilder.BuildTableName();
        tableInfoBuilder.BuildColumns();
        tableInfoBuilder.BuildSortCondition();

        return tableInfoBuilder.GetTableInfo();
    }

    public string ConstructQuerySql(TableInfoBuilder tableInfoBuilder)
    {
        var tableInfo = Construct(tableInfoBuilder);
        return $"select * from {tableInfo.TableName} order by {tableInfo.SortCondition}";
    }
}