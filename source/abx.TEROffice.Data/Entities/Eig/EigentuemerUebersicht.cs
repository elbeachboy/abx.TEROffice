using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace abx.TEROffice.Data.Entities.Eig
{
    public class EigentuemerUebersicht
    {
        [XmlElement("LU2015DUPRECHTAUSZUG")]
        public string LU2015DUPRECHTAUSZUG { get; set; }

        [XmlElement("EIGOCC")]
        public List<Eigentuemer> Eigentümer { get; set; }
    }
}
