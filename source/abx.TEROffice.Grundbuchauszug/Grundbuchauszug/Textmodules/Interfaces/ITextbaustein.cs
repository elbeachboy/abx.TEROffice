using System;
using System.Collections.Generic;
using System.Text;
using DocumentFormat.OpenXml.Wordprocessing;


namespace abx.TEROffice.DocumentProcessing.Grundbuchauszug.Textmodules.Interfaces
{
    public interface ITextbaustein
    {
        Paragraph GetParagraph();
    }
}
