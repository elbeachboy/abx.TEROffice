using System.Collections.Generic;
using System.Xml.Serialization;
using abx.TEROffice.DataReader.Datamodel.AUSZUG.DBK;

namespace abx.TEROffice.DataReader.Datamodel.Shared.AUSZUG.BEZ
{
    public class BEZ
    {
        [XmlElement("BEZOCC")]
        public List<BEZOCC> BEZOCC { get; set; }
    }
}
