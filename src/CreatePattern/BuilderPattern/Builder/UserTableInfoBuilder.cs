namespace CreatePattern.BuilderPattern.Builder;

public class UserTableInfoBuilder : TableInfoBuilder
{
    public override void BuildTableName()
    {
        TableInfo.TableName = "User";
    }

    public override void BuildColumns()
    {
        TableInfo.TableColumns = new List<string>() { "Id", "Name", "Password" };
    }

    public override void BuildSortCondition()
    {
        TableInfo.SortCondition = "Id desc";
    }
}