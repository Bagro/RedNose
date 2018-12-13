using System.Collections.Generic;
using Updater.Enum;

namespace Updater.Entities
{
    public class Store
    {
        public StoreType StoreType { get; set; }

        public string Number { get; set; }

        public string Name { get; set; }

        public string Street { get; set; }

        public string PostalCode { get; set; }

        public string City { get; set; }

        public string County { get; set; }

        public string Phone { get; set; }

        public string Services { get; set; }

        public List<string> SearchWords { get; set; }

        public List<OpenHours> OpeningHours { get; set; }

        public string Rt90x { get; set; }
        
        public string Rt90y { get; set; }
    }
}