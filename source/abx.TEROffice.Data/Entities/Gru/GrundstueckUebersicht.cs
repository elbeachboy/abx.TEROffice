using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using abx.TEROffice.Data.Entities.Bel;
using abx.TEROffice.Data.Entities.Subj;

namespace abx.TEROffice.Data.Entities.Gru
{
    public class GrundstueckUebersicht
    {
        [XmlElement("LU2015_INHALT")]
        public string Auszugseinstellungen_Luzern { get; set; }

        [XmlElement("LU2017_Register")]
        public string LU2017_Register { get; set; }

        [XmlElement("GRUNDST")]
        public Grundstueck Grundstück { get; set; }

        [XmlElement("GRIDBEZ")]
        public string GrundstückIdBezeichnung { get; set; }

        [XmlElement("BRSTAT")]
        public string BRStatus { get; set; }

        [XmlElement("INHOCC")]
        public List<GrundstueckDetails> GrundstuückDetails { get; set; }

        //[XmlElement("URSP")]
        //public string Ursprung { get; set; }

        [XmlElement("SUBJ")]
        public SubjektivUebersicht Subjektiv { get; set; }

        [XmlElement("BEL")]
        public BelegUebersicht Beleg { get; set; }
    }
}
