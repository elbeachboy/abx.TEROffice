using System.Configuration;

namespace abx.TEROffice.Manager.Helpers
{
    public class Helper
    {
        public string GetDataFilePath()
        {
            return ConfigurationManager.AppSettings["DataFilePath"];
        }
    }
}
