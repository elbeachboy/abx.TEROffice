using System.Configuration;
using abx.TEROffice.DocumentProcessing.Exceptionhandling;

namespace abx.TEROffice.Manager.Helpers
{
    public class PathHelper
    {
        public string GetDataFilePath()
        {
            return ConfigurationManager.AppSettings["DataFilePath"];
        }

        public string GetWordTemplatePath(string wordtemplate)
        {
            return ConfigurationManager.AppSettings["WordTemplatePath"] + GetWordTemplateName(wordtemplate);
        }


        public string GetWordOutputPath()
        {
            return ConfigurationManager.AppSettings["WordOutputPath"];
        }

        private string GetWordTemplateName(string name)
        {
            if (name.Equals("LUAuszug"))
            {
                return "Grundbuchauszug.docx";
            }
            else
            {
                throw new BusinessEception();
            }
        }

    }
}
