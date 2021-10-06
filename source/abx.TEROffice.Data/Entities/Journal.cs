using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace abx.TEROffice.Data.Entities
{
    public class Journal
    {
        [XmlElement("ID")]
        public string Id { get; set; }

        [XmlElement("DTX")]
        public DateTime Datum_Unformatiert { get; set; }

        [XmlElement("DT")]
        public string Datum_Formatiert { get; set; }

        [XmlElement("NR")]
        public string Tagebuchnummer { get; set; }

        [XmlElement("ST")]
        public string Status { get; set; }

        [XmlElement("TYP")]
        public string Typ { get; set; }

        [XmlElement("STYP")]
        public string STyp { get; set; }
    }
}
