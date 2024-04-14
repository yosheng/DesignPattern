namespace CreatePattern.SingletonPattern;

/// <summary>
/// 饿汉模式，静态初始化由CLR去创建
/// </summary>
public sealed class ConfigInitialSingleton
{
    private static readonly ConfigInitialSingleton Singleton = new ConfigInitialSingleton();
    
    private Dictionary<string, string> _dictionary = null;
    
    private ConfigInitialSingleton()
    {
        _dictionary = new Dictionary<string, string>();
    }

    public static ConfigInitialSingleton Instance => Singleton;
    
    public void AddConfig(KeyValuePair<string, string> config)
    {
        _dictionary.Add(config.Key, config.Value);
    }

    public string GetConfig(string key)
    {
        return _dictionary[key];
    }

    public List<KeyValuePair<string, string>> GetAllConfig()
    {
        return _dictionary.ToList();
    }
}