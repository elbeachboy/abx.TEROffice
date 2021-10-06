using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace abx.TEROffice.Data.Entities.Bel
{
    public class Beleg
    {
        [XmlElement("ST")]
        public string Status { get; set; }

        [XmlElement("DTX")]
        public DateTime Datum_Unformatiert { get; set; }

        [XmlElement("DT")]
        public string Datum_Formatiert { get; set; }

        [XmlElement("NR")]
        public string BelegNr { get; set; }

        [XmlElement("NRT")]
        public string BelegNrOhneSpace { get; set; }

        [XmlElement("TXT")]
        public string Text { get; set; }
    }
}
