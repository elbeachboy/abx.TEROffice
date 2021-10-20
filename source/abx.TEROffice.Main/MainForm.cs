using System;
using System.Collections.Generic;
using System.Windows.Forms;
using abx.TEROffice.Data.Interfaces;
using abx.TEROFfice.Library.Interfaces;

namespace abx.TEROffice.Main
{
    public partial class MainForm : Form
    {
        private readonly IDeserialisation _deserialisation;
        private readonly ILibrary _library;
        public MainForm(string wordTemplate, string dataFileName, string type, List<String> parameters, string[] args)
        {
            try
            {
                InitializeComponent();
                _deserialisation = (IDeserialisation)Startup._serviceProvider.GetService(typeof(IDeserialisation));
                _library = (ILibrary)Startup._serviceProvider.GetService(typeof(ILibrary));


                var pathHelper = _library.PathHelper(dataFileName,dataFileName,wordTemplate);
               
                var auszug = _deserialisation.CreateAuszugObjekt(pathHelper.DataFilePath);


            }
            catch (Exception e)
            {
                _library.ExceptionHelper().HandleException(e,args);
                Application.Exit();
            }
            
        }


    }
}
