using BehaviorPattern.VisitorPattern.Visit;

namespace BehaviorPattern.VisitorPattern.Element;

public class NurseElement : IElement
{
    public readonly string Name;

    public readonly double WorkHours;

    public NurseElement(string name, double workHours)
    {
        Name = name;
        WorkHours = workHours;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Handle(this);
    }
}