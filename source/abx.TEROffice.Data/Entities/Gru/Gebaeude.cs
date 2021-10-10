using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace abx.TEROffice.Data.Entities.Gru
{
    public class Gebaeude
    {
        [XmlElement("DETAIL")]
        public GebaeudeDetail Detail { get; set; }
    }
}
