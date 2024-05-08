namespace StructurePattern.ProxyPattern;

public class ProxyThirdPartyManager : IThirdPartyManager
{
    private readonly ThirdPartyManager _thirdPartyManager = new ThirdPartyManager();

    public void GetData(string data)
    {
        Console.WriteLine("验证参数是否合法");
        _thirdPartyManager.GetData(data);
        Console.WriteLine("获取完成！");
    }
}