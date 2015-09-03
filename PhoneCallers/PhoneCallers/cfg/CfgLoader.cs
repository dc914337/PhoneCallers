using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PhoneCallers.proxy;

namespace PhoneCallers.cfg
{
    static class CfgLoader
    {
        public static T Load<T>(String path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ProxyPool));
            StreamReader reader = new StreamReader(path);
            var obj = (T)serializer.Deserialize(reader);
            reader.Close();
            return obj;
        }

        public static void Save<T>(String path, T obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StreamWriter writer = new StreamWriter(path);
            serializer.Serialize(writer, obj);
            writer.Close();
        }
    }
}
