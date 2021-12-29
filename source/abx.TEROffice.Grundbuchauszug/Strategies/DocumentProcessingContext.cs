using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using abx.TEROffice.DataReader.Interface;
using abx.TEROffice.DocumentProcessing.Exceptionhandling;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.Interfaces;
using abx.TEROffice.DocumentProcessing.Helper;
using abx.TEROffice.DocumentProcessing.Strategies.Interfaces;
using abx.TEROffice.WordGenerator.Interfaces;
using DocumentFormat.OpenXml.Packaging;

namespace abx.TEROffice.DocumentProcessing.Strategies
{
    public class DocumentProcessingContext : IDocumentProcessingContext
    {
        private IWordStrategy _strategy;

        public void SetStrategy(IWordStrategy strategy)
        {
            this._strategy = strategy;
        }
        
        public void ProceedWord(string dataFileName, string wordTemplate, IData dataReader, IWordGeneratorContext wordGeneratorContext,
            ITextbausteinFactory dienstbarkeitFactory, IWordFactory auszugFactory, PathHelper paths)
        {
            _strategy.ProceedWord(dataFileName,wordTemplate,dataReader,wordGeneratorContext,dienstbarkeitFactory,auszugFactory,paths);
        }
    }
}
