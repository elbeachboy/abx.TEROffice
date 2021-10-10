﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using abx.TEROffice.Data.Entities.Common.Recht;

namespace abx.TEROffice.Data.Entities.Amk
{
    public class AnmerkungUebersicht : RechtUebersicht
    {
        [XmlElement("LROCC")]
        public List<Anmerkung> Anmerkungen { get; set; }

    }
}