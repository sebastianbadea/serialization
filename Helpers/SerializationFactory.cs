using Helpers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class SerializationFactory
    {
        public ISerialization GetSerializationClass(SerializationType type)
        {
            switch (type)
            {
                case SerializationType.Binary:
                    return new BSerialization();
                case SerializationType.DataContract:
                    return new DSerialization();
                case SerializationType.XmlSerialization:
                    return new XSerialization();
                default:
                    throw new Exception("type not supported");
            }
        }
    }
}
