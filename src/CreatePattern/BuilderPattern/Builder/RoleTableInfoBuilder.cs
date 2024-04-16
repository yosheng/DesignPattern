namespace CreatePattern.BuilderPattern.Builder;

public class RoleTableInfoBuilder : TableInfoBuilder
{
    public override void BuildTableName()
    {
        TableInfo.TableName = "Role";
    }

    public override void BuildColumns()
    {
        TableInfo.TableColumns = new List<string>() { "Id", "Name", "Code" };
    }

    public override void BuildSortCondition()
    {
        TableInfo.SortCondition = "Code asc";
    }
}