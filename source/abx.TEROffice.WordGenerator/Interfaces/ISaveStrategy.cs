using System;
using System.Collections.Generic;
using System.Text;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace abx.TEROffice.WordGenerator.Interfaces
{
    public interface ISaveStrategy
    {
        void Save(WordprocessingDocument doc);
    }
}
