namespace StructurePattern.FacadePattern;

public class RegisteredFacade
{
    private readonly PatientSystem _patientSystem;
    private readonly NotifySystem _notifySystem;

    public RegisteredFacade()
    {
        _patientSystem = new PatientSystem();
        _notifySystem = new NotifySystem();
    }

    public void Register(string name)
    {
        _patientSystem.GetInformation(name);
        _notifySystem.SendMessage($"{name}挂号成功");
    }
}