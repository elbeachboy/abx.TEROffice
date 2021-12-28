using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using abx.TEROffice.DataReader.Datamodel.AUSZUG.GRU;

namespace abx.TEROffice.DataReader.Datamodel.Shared.BEL
{
    public class BELOCC
    {
        [XmlElement("ST")] public string ST { get; set; }

        [XmlElement("DTX")] public string DTX { get; set; }

        [XmlElement("DT")] public string DT { get; set; }

        [XmlElement("NR")] public string NR { get; set; }

        [XmlElement("NRT")] public string NRT { get; set; }

        [XmlElement("TXT")] public string TXT { get; set; }

    }
}
