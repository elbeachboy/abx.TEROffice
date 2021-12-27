
using System.Xml.Serialization;
using abx.TEROffice.DataReader.Datamodel.Shared.BEZ;
using abx.TEROffice.DataReader.Datamodel.Shared.INHOCC;

namespace abx.TEROffice.DataReader.Datamodel.AUSZUG.DBK
{
    public class LROCC
    {
        [XmlElement("LRID1")]
        public string LRID1 { get; set; }

        [XmlElement("LRID2")]
        public string LRID2 { get; set; }

        [XmlElement("LRIDTXT")]
        public string LRIDTXT { get; set; }

        [XmlElement("LUSORT")]
        public string LUSORT { get; set; }

        [XmlElement("EREID_FOR_KSA")]
        public string EREID_FOR_KSA { get; set; }

        [XmlElement("ST")]
        public string ST { get; set; }

        [XmlElement("INHOCC")]
        public INHOCC INHOCC { get; set; }

        [XmlElement("LRLR")]
        public string LRLR { get; set; }

        [XmlElement("BEZ")]
        public BEZ BEZ { get; set; }

    }
}
