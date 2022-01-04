using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.Interfaces;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Textbausteine;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Textbausteine.Interfaces;

namespace abx.TEROffice.DocumentProcessing.Grundbuchauszug.Factories.TextbausteinFactories
{
    public class DienstbarkeitFactory : ITextbausteinFactory
    {
        public ITextbaustein CreateTextbaustein(DataReader.Businessmodel.Grundbuchauszug auszug)
        {
            return new DienstbarkeitTextbaustein(auszug);
        }
        }
}
