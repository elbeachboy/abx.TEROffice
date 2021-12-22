using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using abx.TEROffice.DataReader.Datamodel.AUSZUG.GRU;

namespace abx.TEROffice.DataReader.Datamodel.Shared.AUSZUG.BEZ
{
    public class BEZOCC
    {
        [XmlElement("ST")] public string ST { get; set; }

        [XmlElement("GROL")] public string GROL { get; set; }

        [XmlElement("GDTX")] public string GDTX { get; set; }

        [XmlElement("GNR")] public string GNR { get; set; }

        [XmlElement("LNR")] public string LNR { get; set; }

        [XmlElement("GRUNDST")] public GRUNDST GRUNDST { get; set; }

        [XmlElement("PERSON")] public PERSON.PERSON PERSON { get; set; }
    }
}

