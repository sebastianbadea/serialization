using System;
using System.IO;
namespace Helpers
{
    public interface ISerialization
    {
        T Deserialize<T>(Stream stream);
        Stream Serialize<T>(T classObject);
    }
}
