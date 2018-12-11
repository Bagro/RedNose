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

2018-09-21;10:00;19:00;;;0;_*
2018-09-22;10:00;15:00;;;0;_*
2018-09-23;00:00;00:00;;;-;_*
2018-09-24;10:00;18:00;;;0;_*
2018-09-25;10:00;18:00;;;0;_*
2018-09-26;10:00;18:00;;;0;_*
2018-09-27;10:00;19:00;;;0;_*
2018-09-28;10:00;19:00;;;0;_*
2018-09-29;10:00;15:00;;;0;_*
2018-09-30;00:00;00:00;;;-;_*
2018-10-01;10:00;18:00;;;0;_*
2018-10-02;10:00;18:00;;;0;_*
2018-10-03;10:00;18:00;;;0;_*
2018-10-04;10:00;19:00;;;0;_*
2018-10-05;10:00;19:00;;;0;_*
2018-10-06;10:00;15:00;;;0;