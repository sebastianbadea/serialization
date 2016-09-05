using BinarySerializableClasses;
using Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryISerializable
{
    class Program
    {
        static void Main(string[] args)
        {
            var helpers = new Streaming();
            var bSerialization = new BSerialization();
            string filename = AppDomain.CurrentDomain.BaseDirectory + "binaryFile";
            var shop = new Shop { name = "serialized name", rating = 10 };

            Stream strShop = bSerialization.Serialize(shop);

            strShop.Position = 0;

            helpers.SaveToDisk(strShop, filename);

            Stream savedShop = helpers.LoadFromDisk(filename);
            Shop desShop = bSerialization.Deserialize<Shop>(savedShop);

            Console.ReadLine();
        }
    }
}
