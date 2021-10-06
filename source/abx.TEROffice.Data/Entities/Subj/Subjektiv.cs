using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using abx.TEROffice.Data.Entities.Gru;

namespace abx.TEROffice.Data.Entities.Subj
{
    public class Subjektiv
    {
        [XmlElement("LST_ID")]
        public string LastId { get; set; }

        [XmlElement("ESTA_NR")]
        public string Esta_nr { get; set; }

        [XmlElement("ERIDAT")]
        public string Errichtungsdatum { get; set; }

        [XmlElement("EREID_FOR_KSA")]
        public string EREIDFürKsa { get; set; }

        [XmlElement("ST")]
        public string Status { get; set; }

        [XmlElement("GRUNDST")]
        public GrundstueckDetails Grundstück { get; set; }

        [XmlElement("SUBJTYP")]
        public string Typ { get; set; }

        [XmlElement("SUBJTXT")]
        public string SubjektivText { get; set; }

        [XmlElement("SUBJANT")]
        public string SubjektivAnteil { get; set; }
    }
}
