using System;
using System.Windows;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using abx.TEROffice.WordGenerator.Interfaces;
using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace abx.TEROffice.WordGenerator.Strategies
{
    public class SaveAuszugStrategy : ISaveStrategy
    {
        public void Save(WordprocessingDocument doc)
        {
            doc.Save();
        }

        public void Open(string filepath)
        {
            Process.Start("explorer.exe", filepath);
        }

    }
}
