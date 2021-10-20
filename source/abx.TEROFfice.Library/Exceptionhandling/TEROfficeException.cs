using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Text;

namespace abx.TEROFfice.Library
{
    public class TERofficeException : Exception
    {
        public TERofficeException(string message) : base(message)
        {

        }
    }
}
