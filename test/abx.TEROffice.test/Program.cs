using System;
using abx.TEROffice.Data.BLL;
using Xunit;

namespace abx.TEROffice.test
{
    public class Program
    {
        [Fact]
        public void Test()
        {
            var deserializer = new Deserialisation(@"E:\Apps\Diplomarbeit\Datafiles\msg_5216083_2021-10-06-11-40-40.xml");
            deserializer.Deserialisieren();
        }
    }
}
