using System;
using System.Runtime.ExceptionServices;
using abx.TEROffice.Data.BLL;
using abx.TEROffice.Data.Entities;
using abx.TEROffice.Data.Interfaces;
using abx.TEROFfice.Library;
using Xunit;

namespace abx.TEROffice.test
{
    public class TestDeserialize
    {
        private Deserialisation _deserialisation;
        private const string _testFilePath = @"E:\Apps\Diplomarbeit\abx.TEROffice\test\abx.TEROffice.test\Testfiles\msg_5216083_2021-10-06-11-40-40.xml";
        private const string _corruptFIlePath = @"E:\blubbedi\Diplomarbeit\abx.TEROffice\test\abx.TEROffice.test\Testfiles\msg_5216083_2021-10-06-11-40-40.xml";

        private Auszuege _kontrollAuszug = new Auszuege
        {
            TagebuchNr = "12345OS",
            Standort = "OS",
            Benutzername = "Simon Scherer",
            Ort = "Wittenbach",
            Datum = "10.10.2021",
            Zeit = "11.40",
            Grundbuchamt = "Grundbuchamt Luzern V17",
        };

        public TestDeserialize()
        {
            _deserialisation = new Deserialisation();
        }
        
        [Fact]
        public void IsDeserialzeSuccesful()
        {
            var auszug =_deserialisation.CreateAuszugObjekt(_testFilePath);
            Assert.Equal(auszug.Benutzername,_kontrollAuszug.Benutzername);
        }

        [Fact]
        public void Failed_to_load_StreamReader()
        {
            Assert.Throws<TERofficeException>(() => _deserialisation.CreateAuszugObjekt(_corruptFIlePath));
        }

    }
}
