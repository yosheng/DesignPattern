using StructurePattern.AdapterPattern.Scenario1.Domain;

namespace StructurePattern.AdapterPattern.Scenario1.Service;

public class UserAdapter : IUserOperation
{
    private readonly int _userId;

    public UserAdapter(int userId)
    {
        _userId = userId;
    }

    public bool HasReportNotification()
    {
        if (_userId == 1)
        {
            return true;
        }

        return false;
    }
}