using System.Xml.Serialization;
using abx.TEROffice.DataReader.Datamodel.AUSZUG.DBK;

namespace abx.TEROffice.DataReader.Datamodel
{
    public class TERAuszug
    {
        [XmlElement("DBK")]
        public DBK DBK { get; set; }

    }
}
