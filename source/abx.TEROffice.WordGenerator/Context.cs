using System;
using System.Collections.Generic;
using System.Text;
using abx.TEROffice.WordGenerator.Interfaces;
using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace abx.TEROffice.WordGenerator
{
    public class Context : IContext
    {
        private ISaveStrategy _strategy;

        public void SaveWord(WordprocessingDocument doc)
        {
           
            this._strategy.Save(doc);
        }

        public void SetStrategy(ISaveStrategy strategy)
        {
            this._strategy = strategy;
        }
        
        public void Open(string filepath)
        {
           
            this._strategy.Open(filepath);
        }
    }
}
