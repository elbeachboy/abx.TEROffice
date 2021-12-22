using System.Collections.Generic;
using System.Xml.Serialization;

namespace abx.TEROffice.DataReader.Datamodel
{
    [XmlRoot("AUSZUEGE",Namespace = "http://www.nundw.ch/terrisxml01")]
    public class TERAuszuege
    {
        [XmlElement("MSGTBNR")]
        public string MSGTBNR { get; set; }

        [XmlElement("MSGSTAO")]
        public string MSGSTAO { get; set; }

        [XmlElement("USERKRZ")]
        public string USERKRZ { get; set; }

        [XmlElement("ORT")]
        public string ORT { get; set; }

        [XmlElement("DAT")]
        public string DAT { get; set; }

        [XmlElement("ZEIT")]
        public string ZEIT { get; set; }

        [XmlElement("AMT")]
        public string AMT { get; set; }

        [XmlElement("PEROB_GBAID")]
        public string PEROB_GBAID { get; set; }

        [XmlElement("AUSZUG")]
        public List<TERAuszug> LIST_AUSZUG { get; set; }

        [XmlElement("PROVTXT")]
        public string PROVTXT { get; set; }

    }
}
