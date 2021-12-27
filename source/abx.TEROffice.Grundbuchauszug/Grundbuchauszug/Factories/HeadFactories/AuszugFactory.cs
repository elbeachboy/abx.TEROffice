using System;
using System.Collections.Generic;
using System.Text;
using abx.TEROffice.DataReader.Businessmodel.Dienstbarkeiten;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.Interfaces;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.Products;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.TextModuleFactories;
using DocumentFormat.OpenXml.Packaging;

namespace abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.HeadFactories
{
    public class AuszugFactory : IWordFactory
    {
        public IWord CreateWord(WordprocessingDocument doc, DataReader.Businessmodel.Grundbuchauszug auszug)
        {
            return new Auszug(doc, auszug);
        }
    }
}
