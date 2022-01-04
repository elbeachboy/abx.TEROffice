using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Textbausteine.Interfaces;

namespace abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.Interfaces
{
    public interface ITextbausteinFactory
    {
        ITextbaustein CreateTextbaustein(DataReader.Businessmodel.Grundbuchauszug auszug);
    }
}
