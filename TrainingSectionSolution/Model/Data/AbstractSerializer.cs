using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public abstract class AbstractSerializer
    {
        public abstract void Serialize<T>(string filename, T obj);
        public abstract T Deserialize<T>(string filename);
    }
}
