using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using abx.TEROffice.Data.Entities.Common.Personen;
using abx.TEROffice.Data.Entities.Gru;

namespace abx.TEROffice.Data.Entities.Common.LastRechtBeziehungen
{
    public class RechtBeziehungDetail
    {
        [XmlElement("ST")]
        public string Status { get; set; }

        [XmlElement("GROL")]
        public string GROL { get; set; }

        [XmlElement("FAUST")]
        public string Faustpfandgläubiger { get; set; }

        [XmlElement("GDTX")]
        public string Gründungsdatum_Unformatiert { get; set; }

        [XmlElement("GNR")]
        public string Gründungsnummer { get; set; }

        [XmlElement("LDT")]
        public string Löschdatum { get; set; }

        [XmlElement("LNR")]
        public string Löschnummer { get; set; }

        [XmlElement("PERSON")]
        public Person Person { get; set; }

        [XmlElement("GRUNDST")]
        public Grundstueck Grundstueck { get; set; }
    }
}
