using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using abx.TEROffice.Data.Entities.Common.LastRechtBeziehungen;
using abx.TEROffice.Data.Entities.Common.Recht;

namespace abx.TEROffice.Data.Entities.Vmk
{
    public class Vormerkung : Recht
    {
        [XmlElement("INHOCC")]
        public VormerkungDetail VormerkungDetail { get; set; }

        [XmlElement("BEZ")]
        public Beziehung LastRechtBeziehung { get; set; }
    }
}
