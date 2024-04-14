namespace CreatePattern.SingletonPattern;

public sealed class ConfigThreadSafeSingleton
{
    private static ConfigThreadSafeSingleton _instance = null;

    private static readonly object lockOjb = new();
    
    private Dictionary<string, string> _dictionary = null;

    private ConfigThreadSafeSingleton()
    {
        _dictionary = new Dictionary<string, string>();
    }

    public static ConfigThreadSafeSingleton Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (lockOjb)
                {
                    if (_instance == null)
                    {
                        _instance = new ConfigThreadSafeSingleton();
                    }
                }
            }

            return _instance;
        }
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