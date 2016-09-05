using System;
using System.Runtime.Serialization;

namespace BinarySerializableClasses
{
    [Serializable]
    public class Shop: ISerializable
    {
        #region fields
        public string name;
        public int rating;
        #endregion

        #region implementing ISerializable
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("name", name);
        }

        public Shop()
        {

        }

        public Shop(SerializationInfo info, StreamingContext context)
        {
            name = info.GetString("name");
        }
        #endregion
    }
}
