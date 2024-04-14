namespace CreatePattern.SingletonPattern;

/// <summary>
/// 使用 Lazy 懒加载来实例化，用的时候才去创建
/// </summary>
public sealed class ConfigLazyInitialSingleton
{
    private static readonly Lazy<ConfigLazyInitialSingleton> LazySingleton =
        new Lazy<ConfigLazyInitialSingleton>(() => new ConfigLazyInitialSingleton());

    private Dictionary<string, string> _dictionary = null;
    
    private ConfigLazyInitialSingleton()
    {
        _dictionary = new Dictionary<string, string>();
    }

    public static ConfigLazyInitialSingleton Instance => LazySingleton.Value;
    
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