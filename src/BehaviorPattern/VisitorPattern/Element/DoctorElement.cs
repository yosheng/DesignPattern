using BehaviorPattern.VisitorPattern.Visit;

namespace BehaviorPattern.VisitorPattern.Element;

public class DoctorElement : IElement
{
    public readonly string Name;

    public readonly double WorkHours;

    public DoctorElement(string name, double workHours)
    {
        Name = name;
        WorkHours = workHours;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Handle(this);
    }
}