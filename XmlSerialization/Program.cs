using Helpers;
using Helpers.Enums;
using System;
using System.IO;
using XmlSerializableClasses;

namespace XmlSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var helpers = new Streaming();
            var serialization = new SerializationFactory().GetSerializationClass(SerializationType.XmlSerialization);
            string filename = AppDomain.CurrentDomain.BaseDirectory + "XmlSerializableData.xml";

            var person = new Person { Address = new Address { City = "my city", Country = "my country" }, Age = 34, Name = "Sebastian", Id = "11", CreditCardPin="1111", Nickname="Genius" };

            Stream strPerson = serialization.Serialize(person);

            strPerson.Position = 0;

            helpers.SaveToDisk(strPerson, filename);

            Stream savedPerson = helpers.LoadFromDisk(filename);
            Person desPerson = serialization.Deserialize<Person>(savedPerson);

            Console.ReadLine();
        }
    }
}
