using BehaviorPattern.VisitorPattern.Element;
using BehaviorPattern.VisitorPattern.Visit;

namespace BehaviorPattern.VisitorPattern;

public class HospitalStructure
{
    private readonly List<IElement> _elements = new();
    
    public void Add(IElement element)
    {
        _elements.Add(element);
    }
    
    public void Accept(IVisitor visitor)
    {
        foreach (var element in _elements)
        {
            element.Accept(visitor);
        }
    }
}