using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Textbausteine.Interfaces;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Textbausteine.Shared;
using DocumentFormat.OpenXml.Wordprocessing;

namespace abx.TEROffice.DocumentProcessing.Grundbuchauszug.Textbausteine
{
    public class DienstbarkeitTextbaustein : ITextbaustein
    {
        private Paragraph _dienstbarkeit;

        public DienstbarkeitTextbaustein(DataReader.Businessmodel.Grundbuchauszug auszug)
        {

            TabelleTextbaustein tabelle = new TabelleTextbaustein(auszug);

            _dienstbarkeit = tabelle.GetParagraph();

        }

        public Paragraph GetParagraph()
        {
            return this._dienstbarkeit;
        }
    }

}
