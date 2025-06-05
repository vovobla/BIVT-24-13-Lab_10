using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;  

namespace Model.Data
{
    public class JsonSerializer : AbstractSerializer
    {
        public override void Serialize<T>(string filename, T obj)
        {
            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore // <--- добавь эту строку!
            };
            File.WriteAllText(filename, JsonConvert.SerializeObject(obj, Formatting.Indented, settings));
        }

        public override T Deserialize<T>(string filename)
        {
            if (!File.Exists(filename)) return default;
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(filename));
        }
    }
}
