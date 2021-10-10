using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using abx.TEROffice.Data.Entities.Common.LastRechtBeziehungen;

namespace abx.TEROffice.Data.Entities.Gpf
{
   public  class Schuldner
    {
        [XmlElement("BEZ")]
        public Beziehung LastRechtBeziehung { get; set; }
    }
}
