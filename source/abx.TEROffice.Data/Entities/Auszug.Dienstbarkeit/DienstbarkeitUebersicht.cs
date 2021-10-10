using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using abx.TEROffice.Data.Entities.Amk;
using abx.TEROffice.Data.Entities.Common.Recht;

namespace abx.TEROffice.Data.Entities.Dbk
{
    public class DienstbarkeitUebersicht : RechtUebersicht
    {
        [XmlElement("LROCC")]
        public List<Dienstbarkeit> Dienstbarkeiten { get; set; }
    }
}
