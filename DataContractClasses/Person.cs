using System.Runtime.Serialization;

namespace DataContractClasses
{
    [DataContract(IsReference=true)]
    public class Person
    {
        #region properties
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public Address Address { get; set; }
        public string Id { get; set; }
        #endregion
    }
}
