using System;
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

            try
            {
                TabelleTextbaustein tabelle = new TabelleTextbaustein(auszug);

                _dienstbarkeit = tabelle.GetParagraph();
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public Paragraph GetParagraph()
        {
            return this._dienstbarkeit;
        }
    }

}
