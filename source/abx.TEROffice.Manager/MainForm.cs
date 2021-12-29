using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using abx.TEROffice.DataReader.Interface;
using abx.TEROffice.DocumentProcessing.Exceptionhandling;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.Interfaces;
using abx.TEROffice.Manager.Helpers;
using abx.TEROffice.WordGenerator;
using abx.TEROffice.WordGenerator.Interfaces;
using abx.TEROffice.WordGenerator.Strategies;
using DocumentFormat.OpenXml.Packaging;

namespace abx.TEROffice.Main
{
    public partial class MainForm : Form
    {
        private readonly log4net.ILog _logger = log4net.LogManager.GetLogger(typeof(MainForm));
        private readonly IContext _context;
        private readonly IWordFactory _auszugfactory;
        private readonly ITextbausteinFactory _dienstbarkeitFactory;
        private readonly IData _dataReader;
        public MainForm(string wordTemplate, string dataFileName, string type)
        {
            _auszugfactory = (IWordFactory)Startup._serviceProvider.GetService(typeof(IWordFactory));
            _dienstbarkeitFactory = (ITextbausteinFactory)Startup._serviceProvider.GetService(typeof(ITextbausteinFactory));
            _dataReader = (IData)Startup._serviceProvider.GetService(typeof(IData));
            _context = (IContext)Startup._serviceProvider.GetService(typeof(IContext));


            InitializeComponent();
            this.Hide();
            if (type == "Auszug")
            {

                try
                {
                    GenerateAuszug(dataFileName, wordTemplate);
                }
                catch (TerofficeException e)
                {
                    Console.WriteLine(e);
                    throw;
                }


            }


        }

        private void GenerateAuszug(string dataFileName, string wordTemplate)
        {
            try
            {
                var paths = new PathHelper();
                using (WordprocessingDocument doc =
                    WordprocessingDocument.Open(paths.GetWordOutputPath(), true))
                {
                    CreateOuputWord(paths, wordTemplate);

                    var document = _auszugfactory.CreateWord(doc, ReadData(dataFileName,paths), _dienstbarkeitFactory);

                    _context.SetStrategy(new SaveAuszugStrategy());
                    _context.SaveWord(doc);
                    _context.Open(paths.GetWordOutputPath());

                    Application.Exit();

                }
            }
            catch (TerofficeException e)
            {
                Console.WriteLine(e);
                throw;
            }


        }

        private void CreateOuputWord(PathHelper paths, string wordTemplate)
        {

            if (!File.Exists(paths.GetWordOutputPath()))
            {
                File.Copy(paths.GetWordTemplatePath(wordTemplate), paths.GetWordOutputPath());
            }

        }

        private DataReader.Businessmodel.Grundbuchauszug ReadData(string dataFileName, PathHelper paths)
        {
            try
            {
                return _dataReader.GetAuszug(paths.GetDataFilePath() + dataFileName);
            }
            catch (TerofficeException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
