using System;
using System.IO;
using System.Xml.Serialization;

namespace Helpers
{
    public class XSerialization : ISerialization
    {
        public T Deserialize<T>(Stream stream)
        {
            var serializer = new XmlSerializer(typeof(T));

            var classObject = (T)serializer.Deserialize(stream);

            return classObject;
        }

        public Stream Serialize<T>(T classObject)
        {
            var stream = new MemoryStream();
            var serializer = new XmlSerializer(typeof(T));

            serializer.Serialize(stream, classObject);
            
            return stream;
        }
    }
}
