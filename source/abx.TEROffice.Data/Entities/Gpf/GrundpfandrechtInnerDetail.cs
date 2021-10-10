using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace abx.TEROffice.Data.Entities.Gpf
{
    public class GrundpfandrechtInnerDetail
    {
        [XmlElement("LOESCHDATUM")]
        public string Loeschdatum_Unformatiert { get; set; }

        [XmlElement("BEMERKUNG")]
        public string Bemerkung { get; set; }

        [XmlElement("PFANDZINS")]
        public string Pfandzins { get; set; }

        [XmlElement("PFANDSUMME")]
        public string Pfandsumme { get; set; }
    }
}
