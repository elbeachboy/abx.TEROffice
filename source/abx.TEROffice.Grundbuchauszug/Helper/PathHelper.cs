using System.Configuration;

namespace abx.TEROffice.DocumentProcessing.Helper
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
            return "Grundbuchauszug.docx";
        }
    }
}
