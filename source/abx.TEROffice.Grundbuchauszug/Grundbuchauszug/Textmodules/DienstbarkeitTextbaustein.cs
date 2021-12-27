
using System.Collections.Generic;
using abx.TEROffice.DataReader.Businessmodel.Dienstbarkeiten;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Textmodules.Interfaces;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Textmodules.Shared;
using DocumentFormat.OpenXml.Wordprocessing;


namespace abx.TEROffice.DocumentProcessing.Grundbuchauszug.Textmodules
{
    public class DienstbarkeitTextbaustein : ITextbaustein
    {
        private Paragraph _dienstbarkeit;

        public DienstbarkeitTextbaustein(DataReader.Businessmodel.Grundbuchauszug auszug)
        {

            Tabelle tabelle = new Tabelle(auszug);

            _dienstbarkeit = tabelle.GetParagraph();

        }

        public Paragraph GetParagraph()
        {
            return this._dienstbarkeit;
        }
    }

}
