using System;
using System.Collections.Generic;
using System.Text;

namespace abx.TEROffice.Data
{
   public class DataReaderException : Exception
    {
        public DataReaderException(string message) : base(message)
        {
        }
    }
}
