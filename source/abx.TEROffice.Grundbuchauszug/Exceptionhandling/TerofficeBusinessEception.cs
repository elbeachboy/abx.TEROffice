﻿using System;

namespace abx.TEROffice.DocumentProcessing.Exceptionhandling
{
  public class TerofficeBusinessEception : TerofficeException
  {
    public TerofficeBusinessEception(Exception e, string customMessage) : base(e, customMessage)
    {
    }
  }
}
