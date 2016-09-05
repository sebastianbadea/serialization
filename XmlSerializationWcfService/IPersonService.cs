using System.ServiceModel;
using XmlSerializableClasses;

namespace XmlSerializationWcfService
{
    [ServiceContract]
    public interface IPersonService
    {

        [OperationContract]
        [XmlSerializerFormat]
        Person GetPerson();

        [OperationContract]
        [XmlSerializerFormat]
        Shop GetShop();
    }
}
