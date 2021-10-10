using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace abx.TEROffice.Data.Entities.Gru
{
    public class Kulturarten
    {
        [XmlElement("ART")]
        public List<string> Art { get; set; }
    }
}
