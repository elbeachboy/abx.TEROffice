using System;
using System.Collections.Generic;
using System.Text;
using abx.TEROffice.DataReader.Interface;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.Interfaces;
using abx.TEROffice.DocumentProcessing.Helper;
using abx.TEROffice.WordGenerator.Interfaces;

namespace abx.TEROffice.DocumentProcessing.Strategies.Interfaces
{
    public interface IDocumentProcessingContext
    {
        void SetStrategy(IWordStrategy strategy);
        void ProceedWord(string dataFileName, string wordTemplate, IData dataReader, IWordGeneratorContext wordGeneratorContext, ITextbausteinFactory dienstbarkeitFactory, IWordFactory auszugFactory, PathHelper paths);
    }
}
