using System;
using System.Collections.Generic;
using System.Text;
using abx.TEROffice.WordGenerator.Interfaces;
using DocumentFormat.OpenXml.Wordprocessing;

namespace abx.TEROffice.WordGenerator
{
    public class Context
    {
        private ISaveStrategy _strategy;

        private Document doc = new Document();
        

        public Context()
        {
            doc.Append(new Text("Ich bin ein Auszug"));
        }

        public void SaveWord()
        {
           
            this._strategy.Save(doc);
        }

        public void SetStrategy(ISaveStrategy strategy)
        {
            this._strategy = strategy;
        }
    }
}
