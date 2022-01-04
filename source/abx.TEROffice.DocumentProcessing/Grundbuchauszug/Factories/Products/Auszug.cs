using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.Interfaces;
using abx.TEROffice.Shared.Exceptionhandling;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.Products
{
  public class Auszug : IWord
    {
        private ITextbausteinFactory _dienstbarkeitFactory;
        public Auszug(WordprocessingDocument doc, DataReader.Businessmodel.Grundbuchauszug auszug, ITextbausteinFactory dienstbarkeitFactory)
        {
            _dienstbarkeitFactory = dienstbarkeitFactory;
            try
            {
                GenerateAuszug(doc,auszug,dienstbarkeitFactory);
            }
            catch (TerofficeException e)
            {
                throw;
            }


        }

        private void GenerateAuszug(WordprocessingDocument doc, DataReader.Businessmodel.Grundbuchauszug auszug, ITextbausteinFactory dienstbarkeitFactory)
        {

            var body = doc.MainDocumentPart.Document.Body;
            Paragraph para = body.AppendChild(new Paragraph());
            Run run = para.AppendChild(new Run());

            //Factory erstellt den textbaustein
            var dbk = _dienstbarkeitFactory.CreateTextbaustein(auszug);
            Paragraph dienstbarkeit = run.AppendChild(dbk.GetParagraph());
        }

    }
}
