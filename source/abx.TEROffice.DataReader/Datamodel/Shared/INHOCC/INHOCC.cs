using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace abx.TEROffice.DataReader.Datamodel.Shared.INHOCC
{
    public class INHOCC
    {
        [XmlElement("ST")]
        public string ST { get; set; }

        [XmlElement("MDT")]
        public string MDT { get; set; }

        [XmlElement("MNR")]
        public string MNR { get; set; }

        [XmlElement("LRINH")]
        public string LRINH { get; set; }

        [XmlElement("LRINH1")]
        public string LRINH1 { get; set; }

        [XmlElement("LRINH2")]
        public string LRINH2 { get; set; }

        [XmlElement("LRINH3")]
        public string LRINH3 { get; set; }

        [XmlElement("LRINH4")]
        public string LRINH4 { get; set; }

        [XmlElement("ERIDAT")]
        public string ERIDAT { get; set; }

        [XmlElement("BETR")]
        public string BETR { get; set; }

        [XmlElement("TYP")]
        public string TYP { get; set; }

        [XmlElement("NAME")]
        public string NAME { get; set; }

        [XmlElement("VORNAME")]
        public string VORNAME { get; set; }

        [XmlElement("RUFNAME")]
        public string RUFNAME { get; set; }

        [XmlElement("NATIOTXT")]
        public string NATIOTXT { get; set; }

        [XmlElement("GDAT")]
        public string GDAT { get; set; }

        [XmlElement("RFORMTXT")]
        public string RFORMTXT { get; set; }

        [XmlElement("SITZ")]
        public string SITZ { get; set; }

    }
}
