namespace BehaviorPattern.ChainOfResponsibilityPattern;

public abstract class Approver
{
    protected string _name;

    protected Approver _next;

    protected Approver(string name)
    {
        this._name = name;
    }

    public abstract void ProcessApproveData(ApproveData request);

    public void SetNext(Approver approver)
    {
        this._next = approver;
    }
}