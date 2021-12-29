using System;
using System.Collections.Generic;
using System.Text;
using DocumentFormat.OpenXml.Packaging;

namespace abx.TEROffice.WordGenerator.Interfaces
{
    public interface IWordGeneratorContext
    {
        void SaveWord(WordprocessingDocument doc);

        void SetStrategy(ISaveStrategy strategy);

        void Open(string filepath);

    }
}
