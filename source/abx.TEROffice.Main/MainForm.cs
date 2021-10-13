using System;
using System.Windows.Forms;

namespace abx.TEROffice.Main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            try
            {
                InitializeComponent();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

    }
}
