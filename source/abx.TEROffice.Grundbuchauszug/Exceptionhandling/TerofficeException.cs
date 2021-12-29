using System;


namespace abx.TEROffice.DocumentProcessing.Exceptionhandling
{
    public class TerofficeException : Exception
    {
        public void WriteToLog(SystemException e)
        {


        }

        public void WriteToLog(TechnicalException e)
        {

        }

        public void WriteToLog(BusinessEception e)
        {

        }
    }
}
