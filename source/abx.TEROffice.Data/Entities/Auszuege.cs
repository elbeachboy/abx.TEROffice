using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace abx.TEROffice.Data.Entities
{



    [XmlRoot("AUSZUEGE",Namespace = "http://www.nundw.ch/terrisxml01",IsNullable = false)]
    public class Auszuege
    {
        [XmlElement("MSGTBNR")]
        public string TagebuchNr { get; set; }

        [XmlElement("MSGSTAO")]
        public string Standort { get; set; }

        [XmlElement("USERKRZ")]
        public string Benutzername { get; set; }

        [XmlElement("ORT")]
        public string Ort { get; set; }

        [XmlElement("DAT")]
        public string Datum { get; set; }

        [XmlElement("ZEIT")]
        public string Zeit { get; set; }

        [XmlElement("AMT")]
        public string Grundbuchamt { get; set; }

        [XmlElement("PEROB_GBAID")]
        public string PEROB_GBAID { get; set; }

        [XmlElement("AUSZUG")]
        public List<Auszug> Grundbuchauszuege { get; set; }

        [XmlElement("PROVTXT")]
        public string Provisorisch_Text { get; set; }

    }
}
