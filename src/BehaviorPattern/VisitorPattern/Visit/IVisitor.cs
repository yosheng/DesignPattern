using BehaviorPattern.VisitorPattern.Element;

namespace BehaviorPattern.VisitorPattern.Visit;

public interface IVisitor
{
    void Handle(DoctorElement element);
    
    void Handle(NurseElement element);
}