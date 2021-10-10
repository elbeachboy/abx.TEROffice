using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using abx.TEROffice.Data.Entities.Amk;
using abx.TEROffice.Data.Entities.Common.LastRechtBeziehungen;
using abx.TEROffice.Data.Entities.Common.Recht;

namespace abx.TEROffice.Data.Entities.Gpf
{
   public class Grundpfandrecht : Recht
    {
        [XmlElement("TEILBETR")]
        public string Teilbetrag { get; set; }

        [XmlElement("RANG")]
        public string RangMitWhitespace { get; set; }

        [XmlElement("RANGT")]
        public string RangOhneWhitespace { get; set; }

        [XmlElement("GBDBS_NACHRUECK")]
        public string Nachrückungsrecht { get; set; }
        
        [XmlElement("INHOCC")]
        public List<GrundpfandrechtDetail> GrundpfandrechtDetail { get; set; }

        [XmlElement("BEZ")]
        public Beziehung LastRechtBeziehung { get; set; }

        [XmlElement("FAUSTE")]
        public string Faustpfand { get; set; }

        [XmlElement("GLAUB")]
        public Glaeubiger Gläubiger { get; set; }

        [XmlElement("SCHULD")]
        public Schuldner Schuldner { get; set; }
    }
}
