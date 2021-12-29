using System;
using log4net;


namespace abx.TEROffice.DocumentProcessing.Exceptionhandling
{
    public class TerofficeException : Exception
    {
        public void WriteToLog(SystemException e, ILog logger)
        {
            logger.Fatal(e);

        }

        public void WriteToLog(TechnicalException e, ILog logger)
        {
            logger.Error(e);
        }

        public void WriteToLog(BusinessEception e, ILog logger)
        {
            logger.Warn(e);
        }
    }
}
