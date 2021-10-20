using System;
using System.Collections.Generic;
using System.Text;

namespace abx.TEROFfice.Library.Helper
{
    public class WordFormattingHelper
    {
        public string TERofficeklein { get; private set; }

        public string TERofficenormal { get; private set; }

        public string FormateDate(string date)
        {
            if (String.IsNullOrEmpty(date)) return "";
            return Convert.ToDateTime(date).ToString("dd.MM.yyyy");
        }

    }
}
