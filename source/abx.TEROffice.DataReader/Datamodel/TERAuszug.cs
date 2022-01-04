using System.Xml.Serialization;
using abx.TEROffice.DataReader.Datamodel.AUSZUG.DBK;
using abx.TEROffice.DataReader.Datamodel.AUSZUG.GRU;

namespace abx.TEROffice.DataReader.Datamodel
{
    public class TERAuszug
    {
        [XmlElement("DBK")]
        public DBK DBK { get; set; }

        [XmlElement("GRU")]
        public GRU GRU { get; set; }

    }
}
