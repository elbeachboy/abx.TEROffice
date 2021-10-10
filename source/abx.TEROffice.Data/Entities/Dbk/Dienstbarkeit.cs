using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using abx.TEROffice.Data.Entities.Common.LastRechtBeziehungen;
using abx.TEROffice.Data.Entities.Common.Recht;

namespace abx.TEROffice.Data.Entities.Dbk
{
    public class Dienstbarkeit : Recht
    {
        [XmlElement("INHOCC")]
        public DienstbarkeitDetail  DienstbarkeitDetail { get; set; }

        [XmlElement("BEZ")]
        public Beziehung LastRechtBeziehung { get; set; }
    }
}
