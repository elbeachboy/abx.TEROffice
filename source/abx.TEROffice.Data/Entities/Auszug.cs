using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using abx.TEROffice.Data.Entities.Amk;
using abx.TEROffice.Data.Entities.Dbk;
using abx.TEROffice.Data.Entities.Eig;
using abx.TEROffice.Data.Entities.Gru;
using abx.TEROffice.Data.Entities.Vmk;

namespace abx.TEROffice.Data.Entities
{
    public class Auszug
    {
        [XmlElement("PROVFLAG")]
        public string Provisorisch_Flag { get; set; }

        [XmlElement("AUSZTYP0")]
        public string Auszugtyp0 { get; set; }

        [XmlElement("AUSZTYP1")]
        public string Auszugtyp1 { get; set; }

        [XmlElement("AUSZTYP2")]
        public string Auszugtyp2 { get; set; }

        [XmlElement("LU2015_JOU")]
        public List<Journal> Hängige_Geschäfte { get; set; }

        [XmlElement("GRU")]
        public GrundstueckUebersicht Grundstueck { get; set; }

        [XmlElement("EIG")]
        public EigentuemerUebersicht Eigentuemer { get; set; }

        [XmlElement("AMK")]
        public AnmerkungUebersicht Anmerkung { get; set; }

        [XmlElement("DBK")]
        public DienstbarkeitUebersicht Dienstbarkeit { get; set; }

        [XmlElement("VMK")]
        public VormerkungUebersicht Vormerkung { get; set; }
        
    }
}
