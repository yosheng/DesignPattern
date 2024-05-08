namespace StructurePattern.ProxyPattern;

public class ThirdPartyManager
{
    public void GetData(string data)
    {
        Console.WriteLine($"获取到第三方数据:{data}");
    }
}