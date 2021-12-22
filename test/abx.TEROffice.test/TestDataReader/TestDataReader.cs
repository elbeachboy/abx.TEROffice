using abx.TEROffice.DataReader.BLL;
using abx.TEROffice.DataReader.Businessmodel.Dienstbarkeiten;
using Xunit;

namespace abx.TEROffice.test.TestDataReader
{
    public class TestDataReader
    {
        private Data _data = new Data();
        private const string _testFilePath = @"E:\Apps\Diplomarbeit\abx.TEROffice\test\abx.TEROffice.test\Testfiles\msg_5216083_2021-10-06-11-40-40.xml";
        private const string _corruptFIlePath = @"E:\blubbedi\Diplomarbeit\abx.TEROffice\test\abx.TEROffice.test\Testfiles\msg_5216083_2021-10-06-11-40-40.xml";

        private Dienstbarkeit dbk = new Dienstbarkeit
        {
            LastRechId = null,
            LastRechId2 = null,
            LastRechIdGesamt = null,
            Ereid = "CH684160574979",
            Status = null,
            Mutationsdatum = null,
            Mutationsnummer = null,
            LastRechtInhalt = null,
            LastRechtInhaltZusatz = null,
            Errichtungsdatum = null,
            Betrag = null,
            Beziehungen = null
        };



        [Fact]
        public void IsDeserialzeSuccesful()
        {
            var dienstbarkeiten = _data.GetDienstbarkeiten(_testFilePath);
            Assert.Equal(4,dienstbarkeiten.Count);
        }

        [Fact]
        public void IsModelbiuldingSuccessful()
        {
            var dienstbarkeiten = _data.GetDienstbarkeiten(_testFilePath);
            Assert.Equal(dbk.Ereid, dienstbarkeiten[0].Ereid);
        }
    }
}
