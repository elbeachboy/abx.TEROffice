using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace abx.TEROffice.Data.Entities.Gru
{
    public class GebaeudeDetail
    {
        [XmlElement("GEBAEUDENR")]
        public string GebäudeNr { get; set; }

        [XmlElement("GEBAEUDEID")]
        public string GebäudeId { get; set; }

        [XmlElement("GEBAEUDEBEZEICHNUNG")]
        public string Gebäudebezeichnung { get; set; }

        [XmlElement("GEBAEUDESTRASSE")]
        public string Gebäudestrasse { get; set; }

        [XmlElement("GEBAEUDESTATUS")]
        public string Gebäudestatus { get; set; }

        [XmlElement("DRITTEIG")]
        public string Dritteigentum { get; set; }

        [XmlElement("ZUSGRUNDSTUECKE")]
        public string Zusatzgrundstücke { get; set; }

        [XmlElement("VERSWERT")]
        public string Versicherungswert { get; set; }

        [XmlElement("WAEHRUNG")]
        public string Währung { get; set; }

        [XmlElement("VERSDAT")]
        public DateTime Versicherungsdatum_Unformatiert { get; set; }
    }
}
