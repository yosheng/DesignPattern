using BehaviorPattern.VisitorPattern.Visit;

namespace BehaviorPattern.VisitorPattern.Element;

public interface IElement
{
    void Accept(IVisitor visitor);
}