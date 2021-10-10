using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using abx.TEROffice.Data.Entities.Common.LastRechtBeziehungen;

namespace abx.TEROffice.Data.Entities.Common.LastRechtBeziehungen
{
    public class Beziehung
    {
        [XmlElement("BEZOCC")]
        public virtual List<RechtBeziehungDetail> LastBeziehungDetails { get; set; }
    }
}
