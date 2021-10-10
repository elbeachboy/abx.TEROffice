using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using abx.TEROffice.Data.Entities.Bel;
using abx.TEROffice.Data.Entities.Common.LastRechtBeziehungen;
using abx.TEROffice.Data.Entities.Common.Recht;

namespace abx.TEROffice.Data.Entities.Amk
{
    public class Anmerkung : Recht
    {
        [XmlElement("INHOCC")]
        public AnmerkungDetail AnmerkungDetail { get; set; }

        [XmlElement("BEZ")]
        public Beziehung LastRechtBeziehung { get; set; }

    }
}
