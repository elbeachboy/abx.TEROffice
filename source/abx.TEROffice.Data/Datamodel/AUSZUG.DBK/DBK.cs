using System.Collections.Generic;
using System.Xml.Serialization;

namespace abx.TEROffice.DataReader.Datamodel.AUSZUG.DBK
{
    public class DBK
    {
        [XmlElement("LU2015DUPRECHTAUSZUG")]
        public string  Lu2015Duprechtauszug { get; set; }

        [XmlElement("LROCC")]
        public List<LROCC> Lroccs { get; set; }
    }
}
