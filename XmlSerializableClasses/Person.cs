using System.Xml.Serialization;

namespace XmlSerializableClasses
{
    [XmlRoot(ElementName="PersonRoot")]
    public class Person
    {
        #region properties
        [XmlElement]
        public int Age { get; set; }
        [XmlText]
        public string Name { get; set; }
        [XmlElement]
        public Address Address { get; set; }
        [XmlIgnore]
        public string Id { get; set; }
        public string CreditCardPin { get; set; }
        [XmlAttribute]
        public string Nickname { get; set; }
        #endregion
    }
}
