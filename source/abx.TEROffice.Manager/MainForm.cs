using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using abx.TEROffice.DataReader.Interface;
using abx.TEROffice.Shared.Exceptionhandling;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.Interfaces;
using abx.TEROffice.DocumentProcessing.Helper;
using abx.TEROffice.DocumentProcessing.Strategies;
using abx.TEROffice.DocumentProcessing.Strategies.Interfaces;
using abx.TEROffice.Main;
using abx.TEROffice.WordGenerator;
using abx.TEROffice.WordGenerator.Interfaces;
using abx.TEROffice.WordGenerator.Strategies;
using DocumentFormat.OpenXml.Packaging;

namespace abx.TEROffice.Manager
{
    public partial class MainForm : Form
    {
        private readonly log4net.ILog _logger = log4net.LogManager.GetLogger(typeof(MainForm));
        private readonly IWordGeneratorContext _wordGeneratorContext;
        private readonly IDocumentProcessingContext _documentProcessingContext;
        private readonly IWordFactory _auszugFactory;
        private readonly ITextbausteinFactory _dienstbarkeitFactory;
        private readonly IData _dataReader;
        public MainForm(string wordTemplate, string dataFileName, string type)
        {
            try
            {
                _auszugFactory = (IWordFactory)Startup._serviceProvider.GetService(typeof(IWordFactory));
                _dienstbarkeitFactory = (ITextbausteinFactory)Startup._serviceProvider.GetService(typeof(ITextbausteinFactory));
                _dataReader = (IData)Startup._serviceProvider.GetService(typeof(IData));
                _wordGeneratorContext = (IWordGeneratorContext)Startup._serviceProvider.GetService(typeof(IWordGeneratorContext));
                _documentProcessingContext = (IDocumentProcessingContext)Startup._serviceProvider.GetService(typeof(IDocumentProcessingContext));
                _logger.Info("Start Mainform");

                InitializeComponent();
                this.Hide();
                
                if (type == "Auszug")
                {
                    var paths = new PathHelper();
                    _documentProcessingContext.SetStrategy(new AuszugStrategy());
                    _documentProcessingContext.ProceedWord(dataFileName,wordTemplate,_dataReader,_wordGeneratorContext,_dienstbarkeitFactory,_auszugFactory,paths);
                    _logger.Info("Auszug erstellt");
                }
            }

            //Beispielhafte Fehlerbehandlung, wird im Prototyp nicht ausführlich programmiert
            catch (TerofficeSystemException e)
            {
                e.WriteToLog(_logger);
            }
            catch (TerofficeBusinessEception e)
            {
                e.WriteToLog(_logger);
            }
            catch (TerofficeTechnicalException e)
            {
                e.WriteToLog(_logger);
            }
            catch (Exception e)
            {
                _logger.Fatal("Unhandled Exception", e);
            }
            finally
            {
                _logger.Info("End Mainform");
                Application.ExitThread();
            }
        }


    }
}
