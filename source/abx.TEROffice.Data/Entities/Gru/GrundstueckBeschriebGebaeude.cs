using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace abx.TEROffice.Data.Entities.Gru
{
    public class GrundstueckBeschriebGebaeude
    {
        [XmlElement("BESCHRIEB")]
        public string Beschrieb { get; set; }

        [XmlElement("KATASTER")]
        public string Katasterwert { get; set; }

        [XmlElement("KULTURARTEN")]
        public Kulturarten Kulturarten { get; set; }

        [XmlElement("GEBAEUDE")]
        public Gebaeude Gebäude { get; set; }
    }
}
