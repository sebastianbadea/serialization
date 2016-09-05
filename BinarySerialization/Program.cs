using BinarySerializableClasses;
using Helpers;
using Helpers.Enums;
using System;
using System.IO;

namespace BinarySerialization
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var helpers = new Streaming();
            var serialization = new SerializationFactory().GetSerializationClass(SerializationType.Binary);
            string filename = AppDomain.CurrentDomain.BaseDirectory + "binaryFile";
            var person = new Person { address = new Address { city = "my city", country = "my country" }, age = 34, name = "Sebastian", id = "11" };

            Stream strPerson = serialization.Serialize(person);

            strPerson.Position = 0;

            helpers.SaveToDisk(strPerson, filename);

            Stream savedPerson = helpers.LoadFromDisk(filename);
            Person desPerson = serialization.Deserialize<Person>(savedPerson);

            Console.ReadLine();
        }
    }
}
