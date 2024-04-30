namespace StructurePattern.DecoratorPattern.Decorator;

public class TrendDecorator : LogicDecorator
{
    public TrendDecorator(Logic logic) : base(logic)
    {
    }

    public override string PreviewSql()
    {
        return $"select 'Time' as ParameterName, 日期 as ParameterValue, 日期 as Name,count(*) as Value from ({Logic.Sql}) as T group by 日期 order by count(*) desc";
    }
}