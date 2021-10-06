using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace abx.TEROffice.Data.Entities.Eig
{
   public class PersonDetail
    {
        [XmlElement("ST")]
        public string Status { get; set; }

        [XmlElement("TYP")]
        public string Typ { get; set; }

        [XmlElement("NAME")]
        public string Name { get; set; }

        [XmlElement("VORNAME")]
        public string Vorname { get; set; }

        [XmlElement("RUFNAME")]
        public string Rufname { get; set; }

        [XmlElement("GDAT")]
        public string Geburtstag_Formatiert { get; set; }

        [XmlElement("BORT")]
        public string Geburtsort { get; set; }

        [XmlElement("GESCHLCODE")]
        public string Geschlecht { get; set; }
    }
}
