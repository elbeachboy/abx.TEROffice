using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using abx.TEROffice.DataReader.BLL;
using abx.TEROffice.Manager.Helpers;
using log4net;

namespace abx.TEROffice.Main
{
    public partial class MainForm : Form
    {
        private Data _dataReader = new Data();
        private Helper _helper = new Helper();
        public MainForm(string wordTemplate, string dataFileName, string type, List<String> parameters, string[] args)
        {

            

            try
            {
                InitializeComponent();
                if (type == "Auszug")
                {
                    var dbks =_dataReader.GetDienstbarkeiten(_helper.GetDataFilePath() + dataFileName);
                }
               
            }
            catch (Exception e)
            {

            }

        }
    }
}
