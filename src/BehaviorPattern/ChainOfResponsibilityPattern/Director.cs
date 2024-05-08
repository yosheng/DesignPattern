namespace BehaviorPattern.ChainOfResponsibilityPattern;

public class Director : Approver
{
    public Director(string name) : base(name)
    {
    }

    public override void ProcessApproveData(ApproveData request)
    {
        if (request.Price > 0 & request.Price <= 5000)
        {
            Console.WriteLine($"主任审核{request.FlowName}内容{request.FlowContent}");
        }
        else
        {
            _next.ProcessApproveData(request);
        }
    }
}