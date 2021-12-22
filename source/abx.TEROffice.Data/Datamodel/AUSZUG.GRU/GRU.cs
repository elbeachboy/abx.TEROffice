using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace abx.TEROffice.DataReader.Datamodel.AUSZUG.GRU
{
    public class GRU
    {
        [XmlElement("LU2015_INHALT")]
        public string LU2015_INHALT { get; set; }

        [XmlElement("LU2017_Register")]
        public string LU2017_Register { get; set; }

        [XmlElement("GRUNDST")]
        public GRUNDST GRUNDST { get; set; }

        [XmlElement("GRIDBEZ")]
        public string GRIDBEZ { get; set; }

        [XmlElement("BRSTAT")]
        public string BRSTAT { get; set; }
    }
}
