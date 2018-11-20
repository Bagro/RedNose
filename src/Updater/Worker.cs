using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Schemas;
using Updater.Interfaces;

namespace Updater
{
    public class Worker : IWorker
    {
        public Task DoWork()
        {
            var xmlSerializer = new XmlSerializer(typeof(artiklar));

            var streamReader = new StreamReader("/Users/bagro/Downloads/systembolaget/Sortimentsfilen.xml");
            var deserialize = xmlSerializer.Deserialize(streamReader);
            
            return Task.Factory.StartNew(()=> "");
        }
    }
}