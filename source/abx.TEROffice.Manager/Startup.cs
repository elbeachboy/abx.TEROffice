
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Windows.Forms;
using abx.TEROffice.DataReader.BLL;
using abx.TEROffice.DataReader.Interface;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.HeadFactories;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.Interfaces;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.TextbausteinFactories;
using abx.TEROffice.DocumentProcessing.Strategies;
using abx.TEROffice.DocumentProcessing.Strategies.Interfaces;
using abx.TEROffice.WordGenerator;
using abx.TEROffice.WordGenerator.Interfaces;
using DocumentFormat.OpenXml.Office.PowerPoint.Y2021.M06.Main;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;

namespace abx.TEROffice.Main
{
  static class Startup
  {

    public static IServiceProvider _serviceProvider;
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    /// arg[0] = wordTemplate
    /// arg[1] = dataFileName
    /// arg[2] = typ ("Korrespondenz", "Auszug", "GRAVIS")
    /// arg[3+] = div. Params
    [STAThread]
    public static void Main(string[] args)
    {
      log4net.Config.XmlConfigurator.Configure();
      string wordTemplate = args.ElementAtOrDefault(0);
      string dataFileName = args.ElementAtOrDefault(1);
      string type = args.ElementAtOrDefault(2);
      Application.SetHighDpiMode(HighDpiMode.SystemAware);
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      ConfigureServices();
      Application.Run(new MainForm(wordTemplate, dataFileName, type));

    }

    private static void ConfigureServices()
    {
      var services = new ServiceCollection();
      services.AddTransient<IData, Data>();
      services.AddTransient<IWordFactory, AuszugFactory>();
      services.AddTransient<ITextbausteinFactory, DienstbarkeitFactory>();
      services.AddTransient<IWordGeneratorContext, WordGeneratorContext>();
      services.AddTransient<IDocumentProcessingContext, DocumentProcessingContext>();
      _serviceProvider = services.BuildServiceProvider();
    }
  }
}
