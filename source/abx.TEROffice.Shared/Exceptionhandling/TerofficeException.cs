using System;
using log4net;


namespace abx.TEROffice.Shared.Exceptionhandling
{
    public class TerofficeException : Exception
    {
    public TerofficeException(Exception e,string customMessage)
    {
      _customMessage = customMessage;
      _originException = e;
    }
    public Exception _originException { get; set; }
    public string _customMessage { get; set; }
    public void WriteToLog(ILog logger)
        {
            logger.Error(_customMessage,_originException);

        }
    }
}
