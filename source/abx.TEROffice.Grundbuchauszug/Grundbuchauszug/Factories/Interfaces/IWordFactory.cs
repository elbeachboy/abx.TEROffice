using System;
using System.Collections.Generic;
using System.Text;
using abx.TEROffice.DataReader.Businessmodel;
using abx.TEROffice.DataReader.Businessmodel.Dienstbarkeiten;
using DocumentFormat.OpenXml.Packaging;

namespace abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.Interfaces
{
    public interface IWordFactory
    {
        IWord CreateWord(WordprocessingDocument doc, DataReader.Businessmodel.Grundbuchauszug auszug);
    }
}
