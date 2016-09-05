using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Helpers
{
    public class BSerialization: ISerialization
    {
        public T Deserialize<T>(Stream stream)
        {
            var formatter = new BinaryFormatter();

            var classObject = (T)formatter.Deserialize(stream);

            return classObject;
        }

        public Stream Serialize<T>(T classObject)
        {
            var stream = new MemoryStream();

            var formatter = new BinaryFormatter();

            formatter.Serialize(stream, classObject);


            return stream;
        }
    }
}
