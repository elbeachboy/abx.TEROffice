using System;

namespace abx.TEROffice.DocumentProcessing.Exceptionhandling
{
  public class TerofficeTechnicalException : TerofficeException
  {
    public TerofficeTechnicalException(Exception e, string customMessage) : base(e, customMessage)
    {
    }
  }
}
