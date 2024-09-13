namespace StructurePattern.AdapterPattern.Scenario2.Taiwan;

public class TaiwanAdapter : ICharge
{
    private readonly TaiwanSocket _taiwanSocket;

    public TaiwanAdapter()
    {
        this._taiwanSocket = new TaiwanSocket();
    }

    public void Request()
    {
        _taiwanSocket.GerSocket();
    }
}