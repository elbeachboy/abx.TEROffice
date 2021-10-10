using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using abx.TEROffice.Data.Entities.Bel;
using abx.TEROffice.Data.Entities.Common.Personen;

namespace abx.TEROffice.Data.Entities.Eig
{
    public class Eigentuemer
    {
        [XmlElement("LST_ID")]
        public string LastId { get; set; }

        [XmlElement("ESTA_NR")]
        public string EstaNr { get; set; }

        [XmlElement("EREID_FOR_KSA")]
        public string EREID { get; set; }

        [XmlElement("ST")]
        public string Status { get; set; }

        [XmlElement("GDTX")]
        public DateTime Gründungsdatum_Unformatiert { get; set; }

        [XmlElement("GNR")]
        public string GründungsNr { get; set; }

        [XmlElement("LNR")]
        public string LNR { get; set; }

        [XmlElement("PERSON")]
        public Person Person { get; set; }

        [XmlElement("BEL")]
        public BelegUebersicht Beleg { get; set; }
    }
}
