namespace abx.TEROffice.DocumentProcessing.Exceptionhandling
{
  public class TerofficeSystemException : TerofficeException
  {
    public TerofficeSystemException(string customMessage) : base(customMessage)
    {
    }
  }
}
