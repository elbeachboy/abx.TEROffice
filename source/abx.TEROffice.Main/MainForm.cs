using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using abx.TEROffice.DataReader.BLL;
using abx.TEROffice.Manager.Helpers;
using abx.TEROffice.WordGenerator;
using abx.TEROffice.WordGenerator.Interfaces;
using abx.TEROffice.WordGenerator.Strategies;
using log4net;

namespace abx.TEROffice.Main
{
    public partial class MainForm : Form
    {
        private Data _dataReader = new Data();
        private Helper _helper = new Helper();
        private Context _context = new Context();
        public MainForm(string wordTemplate, string dataFileName, string type, List<String> parameters, string[] args)
        {

            

            try
            {
                InitializeComponent();
                if (type == "Auszug")
                {
                    var dbks =_dataReader.GetDienstbarkeiten(_helper.GetDataFilePath() + dataFileName);
                    _context.SetStrategy(new SaveAuszugStrategy());
                    _context.SaveWord();
                }
               
            }
            catch (Exception e)
            {

            }

        }
    }
}
