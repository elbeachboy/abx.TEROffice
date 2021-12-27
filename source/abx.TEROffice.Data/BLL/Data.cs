using System.Collections.Generic;
using abx.TEROffice.DataReader.Businessmodel;
using abx.TEROffice.DataReader.Businessmodel.Dienstbarkeiten;

namespace abx.TEROffice.DataReader.BLL
{
    public class Data
    {
        private Deserialization _deserialization = new Deserialization();
        private Modelbuilder _modelbuilder = new Modelbuilder();
        public Grundbuchauszug GetAuszug(string xmlFilePath)
        {
            var auszuege = _deserialization.DeserializeXml(xmlFilePath);
            return _modelbuilder.FillModel(auszuege.LIST_AUSZUG[0]);
        }
    }
}
