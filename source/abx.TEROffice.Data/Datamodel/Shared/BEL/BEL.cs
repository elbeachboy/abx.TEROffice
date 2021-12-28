using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace abx.TEROffice.DataReader.Datamodel.Shared.BEL
{
    public class BEL
    {
        [XmlElement("BELOCC")]
        public List<BELOCC> BELOCC { get; set; }
    }
}
