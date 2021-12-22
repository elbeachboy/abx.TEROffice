using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace abx.TEROffice.DataReader.Datamodel.AUSZUG.GRU
{
    public class GRUNDST
    {
        [XmlElement("ST")]
        public string ST { get; set; }

        [XmlElement("ST_EIG")]
        public string ST_EIG { get; set; }

        [XmlElement("GRGB")]
        public string GRGB { get; set; }

        [XmlElement("GRID")]
        public string GRID { get; set; }

        [XmlElement("GRART")]
        public string GRART { get; set; }

        [XmlElement("EGRID_FOR_KSA")]
        public string EGRID_FOR_KSA { get; set; }

        [XmlElement("GRGBTXT")]
        public string GRGBTXT { get; set; }

        [XmlElement("GRIDTXT")]
        public string GRIDTXT { get; set; }

        [XmlElement("GRIDT")]
        public string GRIDT { get; set; }

        [XmlElement("GRIDW")]
        public string GRIDW { get; set; }

        [XmlElement("EBLATT")]
        public string EBLATT { get; set; }

        [XmlElement("VERI")]
        public string VERI { get; set; }

        [XmlElement("VERITXT")]
        public string VERITXT { get; set; }
    }
}
