using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.Interfaces;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.Products;
using DocumentFormat.OpenXml.Packaging;

namespace abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.HeadFactories
{
    public class AuszugFactory : IWordFactory
    {
        public IWord CreateWord(WordprocessingDocument doc, DataReader.Businessmodel.Grundbuchauszug auszug, ITextbausteinFactory dienstbarkeitFactory)
        {
            return new Auszug(doc, auszug, dienstbarkeitFactory);
        }
    }
}
