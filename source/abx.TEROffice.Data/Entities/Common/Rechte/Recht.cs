using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using abx.TEROffice.Data.Entities.Bel;

namespace abx.TEROffice.Data.Entities.Common.Recht
{
    public class Recht
    {
        [XmlElement("LRID1")]
        public virtual string LastRechtId1 { get; set; }

        [XmlElement("LRID2")]
        public virtual string LastRechtId2 { get; set; }

        [XmlElement("LRIDTXT")]
        public virtual string LastRechtId3 { get; set; }

        [XmlElement("LUSORT")]
        public virtual string LUSORT { get; set; }

        [XmlElement("EREID_FOR_KSA")]
        public virtual string EREID { get; set; }

        [XmlElement("ST")]
        public virtual string Status { get; set; }

        [XmlElement("LITERA")]
        public virtual string Litera { get; set; }
        
        [XmlElement("LRLR")]
        public virtual string LastOderRecht { get; set; }

        [XmlElement("BEL")]
        public virtual BelegUebersicht BelegUebersicht { get; set; }
    }
}
