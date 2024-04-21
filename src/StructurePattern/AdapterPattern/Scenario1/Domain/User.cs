namespace StructurePattern.AdapterPattern.Scenario1.Domain;

public class User
{
    public int UserId { get; private set; }

    public User(int userId)
    {
        UserId = userId;
    }
    
    public void ShowReportNotification(IUserOperation userOperation)
    {
        if (!userOperation.HasReportNotification())
        {
            throw new Exception("没有报告通知权限");
        }

        Console.WriteLine("读取报告中...");
    }
}