using abx.TEROffice.Data.Entities.Common.Recht;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace abx.TEROffice.Data.Entities.Gpf
{
    public class GrundpfandrechtUebersicht : RechtUebersicht
    {

        [XmlElement("LROCC")]
        public List<Grundpfandrecht> Grundpfandrechte { get; set; }
    }
}
