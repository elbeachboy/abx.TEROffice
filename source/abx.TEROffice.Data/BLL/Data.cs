using System.Collections.Generic;
using abx.TEROffice.DataReader.Businessmodel.Dienstbarkeiten;

namespace abx.TEROffice.DataReader.BLL
{
    public class Data
    {
        private Deserialisation _deserialisation = new Deserialisation();
        private Modelbuilder _modelbuilder = new Modelbuilder();
        public List<Dienstbarkeit> GetDienstbarkeiten(string xmlFilePath)
        {
            var auszuege = _deserialisation.DeserializeXml(xmlFilePath);
            return _modelbuilder.FillModel(auszuege.LIST_AUSZUG[0].DBK.Lroccs);
        }
    }
}
