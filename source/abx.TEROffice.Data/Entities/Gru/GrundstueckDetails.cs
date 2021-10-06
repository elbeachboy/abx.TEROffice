using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace abx.TEROffice.Data.Entities.Gru
{
    public class GrundstueckDetails
    {
        
        [XmlElement("MUTID1")]
        public string MutationsId1 { get; set; }

        [XmlElement("MUTID2")]
        public string MutationsId2 { get; set; }

        [XmlElement("ST")]
        public string Status { get; set; }

        [XmlElement("MDTX")]
        public DateTime MutationsDatum_Unformatted { get; set; }

        [XmlElement("MNR")]
        public string Mutationsnummer { get; set; }

        [XmlElement("FLAE")]
        public string Fläche { get; set; }

        [XmlElement("MUTNRBEZ")]
        public string MutationsNrBezeichnung { get; set; }

        [XmlElement("GRUBES")]
        public string GrundstücksBeschrieb { get; set; }

        [XmlElement("GRUDETAIL")]
        public GrundstueckBeschriebGebaeude BeschriebUndGebäude { get; set; }

        [XmlElement("FLURPLAN")]
        public string Flurplan { get; set; }
    }
}
