using System.Runtime.Serialization;
namespace DataContractClasses
{
    [DataContract]
    public class Address
    {
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string City { get; set; }
    }
}
