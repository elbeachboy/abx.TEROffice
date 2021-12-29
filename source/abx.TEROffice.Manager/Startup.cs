
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Windows.Forms;
using abx.TEROffice.DataReader.BLL;
using abx.TEROffice.DataReader.Interface;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.HeadFactories;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.Interfaces;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.TextbausteinFactories;
using Microsoft.Extensions.DependencyInjection.Extensions;

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
            string wordTemplate = args.ElementAtOrDefault(0);
            string dataFileName = args.ElementAtOrDefault(1);
            string type = args.ElementAtOrDefault(2);
            var parameters = args.Skip(3).ToList();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(new MainForm(wordTemplate, dataFileName, type, parameters, args));
        }

        private static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<IData, Data>();
            services.AddTransient<IWordFactory, AuszugFactory>();
            services.AddTransient<ITextbausteinFactory, DienstbarkeitFactory>();
            _serviceProvider = services.BuildServiceProvider();
        }
    }
}
