using CreatePattern.SingletonPattern;

namespace CreatePattern.Tests.SingletonPattern;

public class ConfigSingletonTest
{
    [Fact]
    public void Test()
    {
        var config = ConfigSingleton.Instance();
        config.AddConfig(new KeyValuePair<string, string>("key", "value"));

        // 添加产品配置
        var productConfig = ConfigSingleton.Instance();
        productConfig.AddConfig(new KeyValuePair<string, string>("product", "product"));
        
        var customizeConfig = ConfigSingleton.Instance();
        var keyValue = customizeConfig.GetConfig("key");
        
        // 判断是否获取相同实例
        Assert.Equal("value", keyValue);
        
        // 判断是否相同实例操作总数
        Assert.Equal(2, config.GetAllConfig().Count);

    }
}