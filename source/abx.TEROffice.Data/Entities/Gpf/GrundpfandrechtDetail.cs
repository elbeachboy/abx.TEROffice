using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using abx.TEROffice.Data.Entities.Common.Recht;

namespace abx.TEROffice.Data.Entities.Gpf
{
    public class GrundpfandrechtDetail : RechtDetail
    {
        [XmlElement("DIV")]
        public string Zins { get; set; }

        [XmlElement("GRUNDPFANDDETAIL")]
        public GrundpfandrechtInnerDetail GrundpfandrechtInnerDetail { get; set; }

        [XmlElement("NACHR")]
        public string Nachrückungsrecht { get; set; }

        [XmlElement("GLEICH")]
        public string Gleichstellung { get; set; }

        [XmlElement("GLEICHST")]
        public string Gleichstellungsstatus { get; set; }
    }
}
