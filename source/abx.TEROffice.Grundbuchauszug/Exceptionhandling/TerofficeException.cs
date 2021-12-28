using System;
using log4net;
using log4net.Core;

namespace abx.TEROffice.DocumentProcessing.Exceptionhandling
{
    public class TerofficeException : Exception
    {
        private readonly ILog _logger;

        public void WriteToLog(SystemException e)
        {
            _logger.Fatal(e);
        }

        public void WriteToLog(TechnicalException e)
        {
            _logger.Error(e);
        }

        public void WriteToLog(BusinessEception e)
        {
            _logger.Info(e);
        }
    }
}
