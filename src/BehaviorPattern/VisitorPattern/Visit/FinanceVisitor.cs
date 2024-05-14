using BehaviorPattern.VisitorPattern.Element;

namespace BehaviorPattern.VisitorPattern.Visit;

public class FinanceVisitor : IVisitor
{
    public void Handle(DoctorElement element)
    {
        Console.WriteLine($"财务部门计算:{element.Name}医生薪资为:{element.WorkHours * 100}");
    }

    public void Handle(NurseElement element)
    {
        Console.WriteLine($"财务部门计算:{element.Name}护士薪资为:{element.WorkHours * 80}");
    }
}