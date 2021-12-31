using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using abx.TEROffice.DataReader.Businessmodel.Dienstbarkeiten;
using abx.TEROffice.Shared.Exceptionhandling;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Textbausteine.Interfaces;
using abx.TEROffice.DocumentProcessing.Helper;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;

namespace abx.TEROffice.DocumentProcessing.Grundbuchauszug.Textbausteine.Shared
{
  public class ZeileTextbaustein : ITextbaustein
  {
    private TableRow _zeile;
    public ZeileTextbaustein(Dienstbarkeit dienstbarkeit, DataReader.Businessmodel.Grundbuchauszug auszug, string columnOne, string columnTwo, string columnThree)
    {
      try
      {
        BuildZeile(dienstbarkeit, auszug, columnOne, columnTwo, columnThree);
      }
      catch (Exception e)
      {
        throw new TerofficeBusinessEception(e, "Fehler beim Erstellen des Textbausteines 'Zeile'.");
      }

    }
    //Wird in diesem Textbaustein nicht gebraucht.
    public Paragraph GetParagraph()
    {
      return null;
    }

    public TableRow GetZeile()
    {
      return this._zeile;
    }

    private void BuildZeile(Dienstbarkeit dienstbarkeit, DataReader.Businessmodel.Grundbuchauszug auszug, string columnOne, string columnTwo, string columnThree)
    {
      _zeile = new TableRow();

      _zeile.Append(new ZelleTextbaustein(columnOne, 1, dienstbarkeit, auszug).GetZelle());
      _zeile.Append(new ZelleTextbaustein(columnTwo, 2, dienstbarkeit, auszug).GetZelle());
      _zeile.Append(new ZelleTextbaustein(columnThree, 3, dienstbarkeit, auszug).GetZelle());
    }



  }

}
