using Newtonsoft.Json;

namespace DTPersonalInfoTracker.Helpers;

public class SerializerHelper
{
    public static string Serialize<T>(T obj)
    {
        return JsonConvert.SerializeObject(obj);
    }
    public static T? Deserialize<T>(string json)
    {
        return JsonConvert.DeserializeObject<T>(json);
    }
}