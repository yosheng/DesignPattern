using BehaviorPattern.VisitorPattern.Element;

namespace BehaviorPattern.VisitorPattern.Visit;

public class HumanResourceVisitor : IVisitor
{
    public void Handle(DoctorElement element)
    {
        Console.WriteLine($"人力资源部门计算:{element.Name}医生工时:{element.WorkHours}");
    }

    public void Handle(NurseElement element)
    {
        Console.WriteLine($"人力资源部门计算:{element.Name}护士工时:{element.WorkHours}");
    }
}