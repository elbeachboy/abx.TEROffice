using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using abx.TEROffice.Data.Entities.Common.Recht;

namespace abx.TEROffice.Data.Entities.Vmk
{
    public class VormerkungUebersicht : RechtUebersicht
    {
        [XmlElement("LROCC")]
        public List<Vormerkung> Vormerkungen { get; set; }
    }
}
