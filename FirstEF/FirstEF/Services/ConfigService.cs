using System.IO;
using Newtonsoft.Json;

namespace FirstEF
{
    public class ConfigService
    {
        public Config GetConfig()
        {
            var configFile = File.ReadAllText("config.json");
            var config = JsonConvert.DeserializeObject<Config>(configFile);
            return config;
        }
    }
}
