using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using abx.TEROffice.DataReader.Businessmodel.Dienstbarkeiten;
using abx.TEROffice.DataReader.Datamodel.AUSZUG.DBK;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.Interfaces;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.TextModuleFactories;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Textmodules;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Textmodules.Interfaces;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.Products
{
    public class Auszug : IWord
    {
        private ITextmoduleFactory _dienstbarkeitFactory;
        public Auszug(WordprocessingDocument doc, DataReader.Businessmodel.Grundbuchauszug auszug)
        {
            MainDocumentPart mainPart = doc.AddMainDocumentPart();

            // Create the document structure and add some text.
            mainPart.Document = new Document();
            Body body = mainPart.Document.AppendChild(new Body());


            _dienstbarkeitFactory = new DienstbarkeitFactory();
            var dbk = _dienstbarkeitFactory.CreateTextModule(auszug);

            Paragraph para = body.AppendChild(new Paragraph());
            Run run = para.AppendChild(new Run());

            Paragraph dienstbarkeit = run.AppendChild(dbk.GetParagraph());
            
            doc.Save();
        }

    }
}
