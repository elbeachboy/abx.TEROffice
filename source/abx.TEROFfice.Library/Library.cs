using System;
using System.Collections.Generic;
using System.Text;
using abx.TEROFfice.Library.Helper;
using abx.TEROFfice.Library.Interfaces;

namespace abx.TEROFfice.Library
{
    public class Library: ILibrary
    {
        private Exceptionhelper _exceptionhelper;
        private PathHelper _pathHelper;
        private WordFormattingHelper _wordFormattingHelper;
        
        public Exceptionhelper ExceptionHelper()
        {
            return _exceptionhelper = new Exceptionhelper();
        }

        public PathHelper PathHelper(string dataFileName, string recipientFileName, string wordTemplateName )
        {
            return _pathHelper = new PathHelper(dataFileName, recipientFileName, wordTemplateName);
        }

        public WordFormattingHelper WordFormattingHelper()
        {
            return _wordFormattingHelper = new WordFormattingHelper();
        }
    }
}
