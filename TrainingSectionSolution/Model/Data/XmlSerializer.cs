using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Model.Data
{
    public class XmlSerializer : AbstractSerializer
    {
        public override void Serialize<T>(string filename, T obj)
        {
            using var fs = new FileStream(filename, FileMode.Create);
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            serializer.Serialize(fs, obj);
        }

        public override T Deserialize<T>(string filename)
        {
            if (!File.Exists(filename)) return default;
            using var fs = new FileStream(filename, FileMode.Open);
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            return (T)serializer.Deserialize(fs);
        }
    }
}
