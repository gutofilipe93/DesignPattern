using System.Xml.Serialization;

namespace Adapter
{
    public class GeradorDeXml
    {
        public string Gerar(object obj)
        {
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, obj);

            return writer.ToString();
        }
    }
}