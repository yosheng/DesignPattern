namespace CreatePattern.BuilderPattern.Builder;

public abstract class TableInfoBuilder
{
    protected TableInfo TableInfo = new();

    public abstract void BuildTableName();

    public abstract void BuildColumns();

    public abstract void BuildSortCondition();

    public TableInfo GetTableInfo()
    {
        return TableInfo;
    }
}