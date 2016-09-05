using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializableClasses
{
    [Serializable]
    public class Person
    {
        #region fields
        public int age;
        public string name;
        public Address address;
        [NonSerialized]
        public string id;
        #endregion

        //[OnSerializing] -> Serialization -> [OnSerialized]
        //[OnDeserializing] -> Deserialization -> [OnDeserialized]
        #region serialization hooks
        [OnSerializing]
        private void OnSerializing(StreamingContext context)
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        [OnSerialized]
        private void OnSerialized(StreamingContext context)
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        [OnDeserializing]
        private void OnDeserializing(StreamingContext context)
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }
        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }
        #endregion
    }
}
