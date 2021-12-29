using System;
using System.Collections.Generic;
using System.Windows.Forms;
using abx.TEROffice.DataReader.Interface;
using abx.TEROffice.DocumentProcessing.Exceptionhandling;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.Interfaces;
using abx.TEROffice.Manager.Helpers;
using abx.TEROffice.WordGenerator;
using abx.TEROffice.WordGenerator.Strategies;
using DocumentFormat.OpenXml.Packaging;

namespace abx.TEROffice.Main
{
    public partial class MainForm : Form
    {
        private Context _context = new Context();
        private readonly IWordFactory _auszugfactory;
        private readonly ITextbausteinFactory _dienstbarkeitFactory;
        private readonly IData _dataReader;
        public MainForm(string wordTemplate, string dataFileName, string type, List<String> parameters, string[] args)
        {
            _auszugfactory = (IWordFactory)Startup._serviceProvider.GetService(typeof(IWordFactory));
            _dienstbarkeitFactory = (ITextbausteinFactory)Startup._serviceProvider.GetService(typeof(ITextbausteinFactory));
            _dataReader = (IData)Startup._serviceProvider.GetService(typeof(IData));

            try
            {
                InitializeComponent();
                if (type == "Auszug")
                {
                    
                    GenerateAuszug(dataFileName,wordTemplate);
                }

            }
            catch (TerofficeException e)
            {
                if (e.GetType() == typeof(DocumentProcessing.Exceptionhandling.SystemException))
                {

                }
                else if (e.GetType() == typeof(BusinessEception))
                {

                }
                else if (e.GetType() == typeof(TechnicalException))
                {

                }
            }

        }

        private void GenerateAuszug(string dataFileName, string wordTemplate)
        {
            var helper = new Helper();
            var auszug = _dataReader.GetAuszug(helper.GetDataFilePath() + dataFileName);

            using (WordprocessingDocument doc =
                WordprocessingDocument.Open(String.Concat(helper.GetWordTemplatePath(),helper.GetWordTemplateName(wordTemplate),".",helper.GetWordTemplateExtension()),true))
            {

                var document = _auszugfactory.CreateWord(doc, auszug, _dienstbarkeitFactory);

                _context.SetStrategy(new SaveAuszugStrategy());
                _context.SaveWord(doc);

            }

            Application.Exit();
        }
    }
}
