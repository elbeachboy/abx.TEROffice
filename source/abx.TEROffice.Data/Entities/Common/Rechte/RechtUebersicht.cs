using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using abx.TEROffice.Data.Entities.Bel;

namespace abx.TEROffice.Data.Entities.Common.Recht
{
    public class RechtUebersicht
    {
        [XmlElement("LU2015DUPRECHTAUSZUG")]
        public virtual string LU2015DUPRECHTAUSZUG { get; set; }

    }
}
