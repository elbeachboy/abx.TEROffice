using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using abx.TEROffice.DataReader.BLL;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.HeadFactories;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.Interfaces;
using abx.TEROffice.Manager.Exceptionhandling;
using abx.TEROffice.Manager.Helpers;
using abx.TEROffice.WordGenerator;
using abx.TEROffice.WordGenerator.Interfaces;
using abx.TEROffice.WordGenerator.Strategies;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using log4net;

namespace abx.TEROffice.Main
{
    public partial class MainForm : Form
    {
        private Data _dataReader = new Data();
        private Helper _helper = new Helper();
        private Context _context = new Context();
        private IWordFactory _factory;
        public MainForm(string wordTemplate, string dataFileName, string type, List<String> parameters, string[] args)
        {

            try
            {
                InitializeComponent();
                if (type == "Auszug")
                {

                    var auszug =_dataReader.GetAuszug(_helper.GetDataFilePath() + dataFileName);

                    using (WordprocessingDocument doc =
                        WordprocessingDocument.Create(@"D:\Schule\TEROffice\Vorlagen\Test.docx",
                            WordprocessingDocumentType.Document))
                    {

                        _factory = new AuszugFactory();
                        var document = _factory.CreateWord(doc,auszug);

                        _context.SetStrategy(new SaveAuszugStrategy());
                        _context.SaveWord();

                    }

                    Application.Exit();
                }
               
            }
            catch (TerofficeException e)
            {

            }

        }
    }
}
