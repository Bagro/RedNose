using System.IO;
using System.Xml.Serialization;
using Updater.Interfaces;

namespace Updater.Bolaget
{
    public class BolagetFilesDeserializer : IDeserializer
    {
        public T Deserialize<T>(string input)
        {
            using (TextReader reader = new StringReader(input))
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                
                var deserialize = xmlSerializer.Deserialize(reader);

                return (T)deserialize;
            }
        }
    }
}