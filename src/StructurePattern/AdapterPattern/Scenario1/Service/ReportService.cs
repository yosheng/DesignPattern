using StructurePattern.AdapterPattern.Scenario1.Domain;

namespace StructurePattern.AdapterPattern.Scenario1.Service;

public class ReportService
{
    public void GetNotification()
    {
        var user = new User(1);
        user.ShowReportNotification(new UserAdapter(user.UserId));
    }
}