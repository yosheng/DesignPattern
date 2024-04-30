namespace StructurePattern.DecoratorPattern.Decorator;

public class DepartmentDecorator : LogicDecorator
{
    public DepartmentDecorator(Logic logic) : base(logic)
    {
    }

    public override string PreviewSql()
    {
        return $"select 'Department' as ParameterName, 科室编号 as ParameterValue, 科室名称 as Name,count(*) as Value from ({Logic.Sql}) as T group by 科室编号,科室名称 order by count(*) desc";
    }
}