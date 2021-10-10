using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace abx.TEROffice.Data.Entities.Common.Recht
{
    public class RechtDetail
    {

        [XmlElement("ST")]
        public virtual string Status { get; set; }

        [XmlElement("MDT")]
        public virtual string Datum_Unformatiert { get; set; }

        [XmlElement("MNR")]
        public virtual string Nummer { get; set; }

        [XmlElement("LRINH")]
        public virtual string LastRechtInhalt { get; set; }

        [XmlElement("LRINH1")]
        public virtual string LastRechtInhalt1 { get; set; }

        [XmlElement("LRINH2")]
        public virtual string LastRechtInhalt2 { get; set; }

        [XmlElement("LRINH3")]
        public virtual string LastRechtInhalt3 { get; set; }

        [XmlElement("LRINH4")]
        public virtual string LastRechtInhalt4 { get; set; }

        [XmlElement("ERIDAT")]
        public virtual string Errichtungsdatum { get; set; }

        [XmlElement("BETR")]
        public virtual string Betrag { get; set; }

        [XmlElement("BETRW")]
        public virtual string BetragInWorten { get; set; }
    }
}
