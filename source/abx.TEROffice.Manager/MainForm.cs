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
      try
      {
        _auszugfactory = (IWordFactory)Startup._serviceProvider.GetService(typeof(IWordFactory));
        _dienstbarkeitFactory = (ITextbausteinFactory)Startup._serviceProvider.GetService(typeof(ITextbausteinFactory));
        _dataReader = (IData)Startup._serviceProvider.GetService(typeof(IData));
        _context = (IContext)Startup._serviceProvider.GetService(typeof(IContext));
        _logger.Info("Start Mainform");

        InitializeComponent();
        this.Hide();

        if (type == "Auszug")
        {
          GenerateAuszug(dataFileName, wordTemplate);
          _logger.Info("Auszug erstellt");
        }
      }

      //Beispielhafte Fehlerbehandlung, wird im Prototyp nicht ausfürlich programmiert
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
      }
    }

    private void GenerateAuszug(string dataFileName, string wordTemplate)
    {
      var paths = new PathHelper();
      using (WordprocessingDocument doc =
          WordprocessingDocument.Open(paths.GetWordOutputPath(), true))
      {
        CreateOuputWord(paths, wordTemplate);
        var document = _auszugfactory.CreateWord(doc, ReadData(dataFileName, paths), _dienstbarkeitFactory);

        _context.SetStrategy(new SaveAuszugStrategy());
        _context.SaveWord(doc);
        _context.Open(paths.GetWordOutputPath());

        Application.Exit();
      }
    }

    private void CreateOuputWord(PathHelper paths, string wordTemplate)
    {
      //techischer Fehler
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
      catch (Exception e)
      {
        throw new TerofficeTechnicalException(e,"File nicht gefunden");
      }

    }
  }
}
