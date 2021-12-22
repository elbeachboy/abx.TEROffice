using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using abx.TEROffice.DataReader.Datamodel.AUSZUG.DBK;

namespace abx.TEROffice.DataReader.Datamodel.Shared.AUSZUG.PERSON
{
    public class PERSON
    {
        [XmlElement("ID")]
        public string ID { get; set; }

        [XmlElement("NEST-PID")]
        public string NEST_PID { get; set; }

        [XmlElement("NIV")]
        public string NIV { get; set; }

        [XmlElement("STRASSE")]
        public string STRASSE { get; set; }

        [XmlElement("LAND")]
        public string LAND { get; set; }

        [XmlElement("PLZ")]
        public string PLZ { get; set; }

        [XmlElement("ORT")]
        public string ORT { get; set; }

        [XmlElement("GESCHLCODE")]
        public string GESCHLCODE { get; set; }

        [XmlElement("BORT")]
        public string BORT { get; set; }

        [XmlElement("ZIVTXT")]
        public string ZIVTXT { get; set; }

        [XmlElement("ANREDE")]
        public string ANREDE { get; set; }

        [XmlElement("INHOCC")]
        public INHOCC INHOCC { get; set; }

    }
}
