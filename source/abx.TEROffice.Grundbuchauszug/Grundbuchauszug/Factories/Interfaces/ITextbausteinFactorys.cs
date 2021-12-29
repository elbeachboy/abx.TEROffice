using System;
using System.Collections.Generic;
using System.Text;
using abx.TEROffice.DataReader.Businessmodel.Dienstbarkeiten;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Textbausteine.Interfaces;
using DocumentFormat.OpenXml.Wordprocessing;

namespace abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.Interfaces
{
    public interface ITextbausteinFactory
    {
        ITextbaustein CreateTextbaustein(DataReader.Businessmodel.Grundbuchauszug auszug);
    }
}
