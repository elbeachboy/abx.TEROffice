using System;
using System.Collections.Generic;
using System.Text;
using abx.TEROffice.DataReader.Businessmodel.Dienstbarkeiten;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.Interfaces;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Textmodules;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Textmodules.Interfaces;
using DocumentFormat.OpenXml.Wordprocessing;

namespace abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.TextModuleFactories
{
    public class DienstbarkeitFactory : ITextmoduleFactory
    {
        public ITextbaustein CreateTextModule(DataReader.Businessmodel.Grundbuchauszug auszug)
        {
            return new DienstbarkeitTextbaustein(auszug);
        }
    }
}
