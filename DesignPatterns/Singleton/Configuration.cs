namespace DesignPatterns.Singleton;

public class Configuration
{
    private static object _obj = new object();
    
    private static Configuration _configuration = null;
    public string StringProperty { get; set; }
    public int IntProperty { get; set; }

    private Configuration()
    {
    }
    
    
    public static Configuration GetInstance()
    {
        lock (_obj)
        {
            if (_configuration == null)
            {
                _configuration = new Configuration();
            }
        }
        

        return _configuration;
    }
    
    
}