namespace CreatePattern.SingletonPattern;

public sealed class ConfigSingleton
{
    private static ConfigSingleton _instance = null;

    private Dictionary<string, string> _dictionary = null;

    private ConfigSingleton()
    {
        _dictionary = new Dictionary<string, string>();
    }

    public static ConfigSingleton Instance()
    {
        if (_instance == null)
        {
            _instance = new ConfigSingleton();
        }

        return _instance;
    }

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