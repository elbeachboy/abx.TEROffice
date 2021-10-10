using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace abx.TEROffice.Data.Entities.Subj
{
    public class SubjektivUebersicht
    {
        [XmlElement("LU2015DUPRECHTAUSZUG")]
        public string LU2015DUPRECHTAUSZUG { get; set; }

        [XmlElement("SUBJOCC")]
        public List<Subjektiv> Subjektivs { get; set; }
    }
}
