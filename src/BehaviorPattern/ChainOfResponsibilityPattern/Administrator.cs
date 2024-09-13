namespace BehaviorPattern.ChainOfResponsibilityPattern;

public class Administrator : Approver
{
    public Administrator(string name) : base(name)
    {
    }

    public override void ProcessApproveData(ApproveData request)
    {
        if (request.Price > 10000)
        {
            Console.WriteLine($"管理员审核{request.FlowName}内容{request.FlowContent}");
        }
        else
        {
            _next.ProcessApproveData(request);
        }
    }
}