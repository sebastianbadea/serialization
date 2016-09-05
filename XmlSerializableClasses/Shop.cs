using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace XmlSerializableClasses
{
    [XmlSchemaProvider("GetShopSchema")]
    public class Shop: IXmlSerializable
    {
        #region fields
        public string name;
        public int rating;
        #endregion

        #region serialization
        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            reader.Read();
            name = reader.GetAttribute("Name");
            reader.Read();
            reader.Read();
            rating = Convert.ToInt32(reader.Value);
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement("ShopInfo");

            writer.WriteAttributeString("Name", name);

            writer.WriteElementString("rating", rating.ToString());

            writer.WriteEndElement();
        }
        #endregion

        #region schema provider
        public static XmlQualifiedName GetShopSchema(XmlSchemaSet xs)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "ShopSchema.xsd";
            using (var stream = new FileStream(path, FileMode.Open))
            {
                var shopSchema = XmlSchema.Read(stream, null);
                xs.Add(shopSchema);
            }

            return new XmlQualifiedName("Shop", "http://serialization.shop");
        }
        #endregion
    }
}
