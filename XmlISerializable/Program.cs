using Helpers;
using Helpers.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmlSerializableClasses;

namespace XmlISerializable
{
    class Program
    {
        static void Main(string[] args)
        {
            var helpers = new Streaming();
            var serialization = new SerializationFactory().GetSerializationClass(SerializationType.XmlSerialization);
            string filename = AppDomain.CurrentDomain.BaseDirectory + "XmlSerializableData.xml";

            var shop = new Shop { name = "my shop", rating = 2 };
            Stream strShop = serialization.Serialize(shop);

            strShop.Position = 0;

            helpers.SaveToDisk(strShop, filename);

            Stream savedShop = helpers.LoadFromDisk(filename);
            Shop desPerson = serialization.Deserialize<Shop>(savedShop);

            Console.ReadLine();
        }
    }
}
