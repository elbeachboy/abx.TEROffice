using System;

namespace abx.TEROffice.DocumentProcessing.Exceptionhandling
{
  public class TerofficeSystemException : TerofficeException
  {
      public TerofficeSystemException(Exception e, string customMessage) : base(e, customMessage)
      {
      }
  }
}
