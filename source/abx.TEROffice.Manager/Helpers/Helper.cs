using System.Configuration;
using abx.TEROffice.DocumentProcessing.Exceptionhandling;

namespace abx.TEROffice.Manager.Helpers
{
    public class Helper
    {
        public string GetDataFilePath()
        {
            return ConfigurationManager.AppSettings["DataFilePath"];
        }

        public string GetWordTemplatePath()
        {
            return ConfigurationManager.AppSettings["WordTemplatePath"];
        }

        public string GetWordTemplateExtension()
        {
            return ConfigurationManager.AppSettings["WordTemplateExtension"];
        }

        public string GetWordTemplateName(string name)
        {
            if (name.Equals("LUAuszug"))
            {
                return "Grundbuchauszug";
            }
            else
            {
                throw new BusinessEception();
            }
        }

    }
}
