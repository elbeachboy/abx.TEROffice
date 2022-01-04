using DocumentFormat.OpenXml.Packaging;

namespace abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.Interfaces
{
    public interface IWordFactory
    {
        IWord CreateWord(WordprocessingDocument doc, DataReader.Businessmodel.Grundbuchauszug auszug, ITextbausteinFactory _dienstbarkeitFactory);
    }
}
