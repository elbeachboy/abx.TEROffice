using System;

namespace abx.TEROffice.Shared.Exceptionhandling
{
  public class TerofficeSystemException : TerofficeException
  {
      public TerofficeSystemException(Exception e, string customMessage) : base(e, customMessage)
      {
      }
  }
}
