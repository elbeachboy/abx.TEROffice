using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace abx.TEROffice.Data.Entities.Bel
{
    public class BelegUebersicht
    {
        [XmlElement("BELOCC")]
        public List<Beleg> Belege { get; set; }
    }
}
