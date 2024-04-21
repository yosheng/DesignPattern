namespace StructurePattern.AdapterPattern.Scenario2.China;

public class ChinaAdapter : ICharge
{
    private readonly ChinaSocket _chinaSocket;

    public ChinaAdapter()
    {
        this._chinaSocket = new ChinaSocket();
    }

    public void Request()
    {
        _chinaSocket.GerSocket();
    }
}