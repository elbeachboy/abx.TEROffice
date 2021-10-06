using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace abx.TEROffice.Data.Entities
{
    public class BeziehungAuf
    {
        [XmlElement("LU2015DUPRECHTAUSZUG")]
        public string LU2015DUPRECHTAUSZUG { get; set; }
    }
}
