using System;
using System.Collections.Generic;
using System.Text;
using abx.TEROffice.DataReader.Businessmodel.Dienstbarkeiten;

namespace abx.TEROffice.DataReader.Businessmodel
{
    public class Grundbuchauszug
    {
        public Grundstück Grundstueck { get; set; }

        public List<Dienstbarkeit> Dienstbarkeiten { get; set; }
    }
}
