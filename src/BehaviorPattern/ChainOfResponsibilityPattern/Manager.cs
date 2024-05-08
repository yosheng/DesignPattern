namespace BehaviorPattern.ChainOfResponsibilityPattern;

public class Manager : Approver
{
    public Manager(string name) : base(name)
    {
    }

    public override void ProcessApproveData(ApproveData request)
    {
        if (request.Price > 5000 & request.Price <= 10000)
        {
            Console.WriteLine($"经理审核{request.FlowName}内容{request.FlowContent}");
        }
        else
        {
            _next.ProcessApproveData(request);
        }
    }
}