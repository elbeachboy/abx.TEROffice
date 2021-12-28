using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using abx.TEROffice.DataReader.Businessmodel.Dienstbarkeiten;
using abx.TEROffice.DocumentProcessing.Helper;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;

namespace abx.TEROffice.DocumentProcessing.Grundbuchauszug.Textbausteine.Shared
{
  public class ZeileTextbaustein
  {
    private TableRow _zeile;
    public ZeileTextbaustein(Dienstbarkeit dienstbarkeit, DataReader.Businessmodel.Grundbuchauszug auszug, string columnOne, string columnTwo, string columnThree)
    {

      //zeile muss irgendwie noch in Zelle aufgesplittet werden
      _zeile = new TableRow();

      _zeile.Append(new ZelleTextbaustein(columnOne, 1, dienstbarkeit, auszug).GetZelle());
      _zeile.Append(new ZelleTextbaustein(columnTwo, 2, dienstbarkeit, auszug).GetZelle());
      _zeile.Append(new ZelleTextbaustein(columnThree, 3, dienstbarkeit, auszug).GetZelle());
    }

    public TableRow GetZeile()
    {
      return this._zeile;
    }

  }

}
