using System;
using System.Collections.Generic;
using System.Text;
using abx.TEROFfice.Library.Helper;

namespace abx.TEROFfice.Library.Interfaces
{
    public interface ILibrary
    {
        Exceptionhelper ExceptionHelper();

        PathHelper PathHelper(string dataFileName, string recipientFileName, string wordTemplateName);

        WordFormattingHelper WordFormattingHelper();

    }
}
