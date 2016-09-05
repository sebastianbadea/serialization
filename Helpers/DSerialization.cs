using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class DSerialization : ISerialization
    {
        public T Deserialize<T>(Stream stream)
        {
            var serializer = new DataContractSerializer(typeof(T));

            var classObject = (T)serializer.ReadObject(stream);

            return classObject;
        }

        public Stream Serialize<T>(T classObject)
        {
            var stream = new MemoryStream();
            var serializer = new DataContractSerializer(typeof(T));

            serializer.WriteObject(stream, classObject);

            return stream;
        }
    }
}
