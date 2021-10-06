using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace abx.TEROffice.Data.Entities.Gru
{
    public class Grundstueck
    {
        [XmlElement("ST")]
        public string Status { get; set; }

        [XmlElement("ST_EIG")]
        public string Status_Eigentümer { get; set; }

        [XmlElement("GRGB")]
        public string Grundbuchnummer { get; set; }

        [XmlElement("GRID")]
        public string GrundstückId { get; set; }

        [XmlElement("GRART")]
        public string Grundstücksart { get; set; }

        [XmlElement("EGRID_FOR_KSA")]
        public string EGRIDFürKsa { get; set; }

        [XmlElement("GRGBTXT")]
        public string Grundbuchname { get; set; }

        [XmlElement("GRIDTXT")]
        public string GrundstückIdMitText { get; set; }

        [XmlElement("GRIDT")]
        public string GrundstückIdOhneText { get; set; }

        [XmlElement("GRIDW")]
        public string GrundstückIdInWorten { get; set; }

        [XmlElement("VERI")]
        public string Verifikation { get; set; }

        [XmlElement("VERITXT")]
        public string VerifikationText { get; set; }
    }


}
