using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace abx.TEROFfice.Library.Helper
{
    public class PathHelper
    {
        private const string _output = "Output";
        public PathHelper(string datafileName, string recipientFileName, string wordTemplate)
        {
            RecipientFileExtension = ConfigurationManager.AppSettings["RecipientFileExtension"];
            DatafileExtension = ConfigurationManager.AppSettings["DataFileExtension"];
            WordTemplateExtension = ConfigurationManager.AppSettings["WordTemplateExtension"];
            WordCultureCurrencySymbol = ConfigurationManager.AppSettings["wordCultureCurrencySymbol"];
            Encoding = ConfigurationManager.AppSettings["encoding"] ?? "default";
            DatafileName = datafileName;
            RecipientFilename = recipientFileName;
            WordTemplateName = wordTemplate;
            WordOutputPath = ConfigurationManager.AppSettings["WordOutputPath"] + _output + ConfigurationManager.AppSettings["WordTemplateExtension"];
            WordTemplatePath = ConfigurationManager.AppSettings["WordTemplatePath"];
            RecipientFolderPath = ConfigurationManager.AppSettings["DataFilePath"] + RecipientFilename + RecipientFileExtension;
            DataFolderPath =  ConfigurationManager.AppSettings["DataFilePath"];
            DataFilePath =  DataFolderPath + DatafileName;
            RecipientFilePath = RecipientFolderPath + RecipientFilename;
        }

        public string RecipientFileExtension { get; set; }

        public string DatafileExtension { get; set; }

        public string WordTemplateExtension { get; set; }

        public string WordCultureCurrencySymbol { get; set; }

        public string Encoding { get; set; }

        public string DatafileName { get; set; }

        public string RecipientFilename { get; set; }

        public string WordTemplateName { get; set; }

        public string DataFilePath { get; set; }

        public string RecipientFilePath { get; set; }

        public string WordTemplatePath { get; set; }

        public string WordOutputPath { get; set; }

        public string WordTemplateFolderPath { get; set; }

        public string DataFolderPath { get; set; }

        public string RecipientFolderPath { get; set; }
    }
}
