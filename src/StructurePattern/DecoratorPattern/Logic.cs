namespace StructurePattern.DecoratorPattern;

public class Logic : LogicComponent
{
    public Logic(string sql)
    {
        Sql = sql;
    }

    public string Sql { get; }

    public override string PreviewSql()
    {
        return Sql;
    }
}