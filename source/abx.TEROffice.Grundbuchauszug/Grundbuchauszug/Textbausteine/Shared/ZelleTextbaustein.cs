using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using abx.TEROffice.DataReader.Businessmodel.Dienstbarkeiten;
using abx.TEROffice.DocumentProcessing.Exceptionhandling;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Textbausteine.Interfaces;
using abx.TEROffice.DocumentProcessing.Helper;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;

namespace abx.TEROffice.DocumentProcessing.Grundbuchauszug.Textbausteine.Shared
{
  public class ZelleTextbaustein : ITextbaustein
  {
    private TableCell _zelle;
    public ZelleTextbaustein(string columnwidth, int row, Dienstbarkeit dienstbarkeit, DataReader.Businessmodel.Grundbuchauszug auszug)
    {
      try
      {
        if (row == 1)
        {
          _zelle = CreateTextCell(columnwidth, $"{dienstbarkeit.LastRechIdGesamt.TrimStart(' ')}: {dienstbarkeit.LastRechtBezeichnung.Replace(":", "")}");
        }
        else if (row == 2)
        {
          _zelle = CreateTextCell(BuildRechteText(dienstbarkeit, auszug.Grundstueck.Grundbuchnummer), columnwidth);
        }
        else if (row == 3)
        {
          _zelle = CreateTextCell(BuildRechteBelege(dienstbarkeit), columnwidth);
        }
      }
      catch (Exception e)
      {
        throw new TerofficeBusinessEception(e, "Fehler beim Erstellen des Textbausteines 'Zelle'.");
      }
    }

    //Wird in diesem Textbaustein nicht gebraucht.
    public Paragraph GetParagraph()
    {
      return null;
    }

    public TableCell GetZelle()
    {
      return this._zelle;
    }

    private TableCell CreateTextCell(string width, string content, bool bold = false, int? colspan = null, JustificationValues alignment = JustificationValues.Left, string shading = null, MergedCellValues? merge = null, TableCellBorders border = null, string fontSize = null)
    {
      TableCell tableCell = new TableCell();
      TableCellProperties tableCellProperties = new TableCellProperties();
      if (merge != null)
      {
        tableCellProperties.Append(new VerticalMerge() { Val = merge });
      }
      TableCellWidth tableCellWidth = new TableCellWidth() { Width = width, Type = TableWidthUnitValues.Dxa };

      if (shading != null)
      {
        tableCellProperties.Append(new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = shading });
      }

      tableCellProperties.Append(tableCellWidth);
      if (border != null)
      {
        tableCellProperties.Append((TableCellBorders)border.Clone());
      }

      Paragraph paragraph = new Paragraph();
      ParagraphProperties paraprop = new ParagraphProperties();
      Justification justification = new Justification() { Val = alignment };
      Indentation indent = new Indentation() { Right = "0" };
      paraprop.Append(justification);
      paraprop.Append(indent);
      paragraph.Append(paraprop);


      Run run = new Run();
      Text text = new Text { Text = content };

      if (bold)
      {
        RunProperties runProperties = new RunProperties();
        runProperties.Append(new Bold());
        run.Append(runProperties);
      }

      if (fontSize != null)
      {
        if (run.RunProperties == null)
        {
          run.RunProperties = new RunProperties();
        }

        run.RunProperties.FontSize = new FontSize() { Val = fontSize };
      }

      if (colspan != null)
      {
        GridSpan gridSpan = new GridSpan() { Val = colspan };
        tableCellProperties.Append(gridSpan);
      }

      run.Append(text);
      paragraph.Append(run);
      tableCell.Append(tableCellProperties);
      tableCell.Append(paragraph);
      return tableCell;
    }

    private TableCell CreateTextCell(List<Paragraph> content, string width, int? colspan = null, MergedCellValues? merge = null, TableCellBorders border = null)
    {
      if (content.Count == 0)
      {
        content.Add(new Paragraph(new Run(new Text())));
      }

      TableCell tableCell = new TableCell();
      TableCellProperties tableCellProperties = new TableCellProperties();
      TableCellWidth tableCellWidth = new TableCellWidth() { Width = width, Type = TableWidthUnitValues.Dxa };
      if (border != null)
      {
        tableCellProperties.AppendChild((TableCellBorders)border.Clone());
      }

      if (merge != null)
      {
        tableCellProperties.Append(new VerticalMerge() { Val = merge });
      }

      tableCellProperties.Append(tableCellWidth);
      if (colspan != null)
      {
        GridSpan gridSpan = new GridSpan() { Val = colspan };
        tableCellProperties.Append(gridSpan);
      }

      tableCell.Append(tableCellProperties);
      tableCell.Append(content);

      return tableCell;
    }

    private List<Paragraph> BuildRechteText(Dienstbarkeit dienstbarkeit, string rootKreis, bool showRangaenderung = true)
    {
      var result = new List<Paragraph>();

      if (dienstbarkeit.Beziehungen != null && dienstbarkeit.Beziehungen.Any(i => i.Status == "R"))
      {
        var nrText = false;
        Dictionary<string, List<List<Run>>> dicGS = new Dictionary<string, List<List<Run>>>();
        Dictionary<string, List<Paragraph>> dicPersons = new Dictionary<string, List<Paragraph>>();
        // z.G. oder z.L. nur einmal einfügen am Anfang
        bool grolTextSet = false;
        dienstbarkeit.Beziehungen.Where(i => i.Status == "R").ToList().ForEach(i =>
        {
          var key = i.Grol;
          if (!dicGS.ContainsKey(key)) dicGS.Add(key, new List<List<Run>>());
          if (i.Grundstück.Grundbuchnummer != null)
          {
            nrText = true;
            var value = String.Join(", ", GetGSNummer(i.Grundstück, rootKreis));
            List<Run> textList = new List<Run>();
            if (dicGS[key].Count == 0)
            {
              textList.Add(new Run(new Text(value)));
              dicGS[key].Add(textList);
            }
            else
            {
              var text = dicGS[key][0];
              text.Add(new Run(new Text(", " + value)));
            }
          }

          if (i.Person.Status != null)
          {


            string einzugHaengend = "0";
            string einzugErsteLinie = "0";
            string einzug = "424";
            var personText = GetPersonText(i.Person);
            var runList = personText.Item1; // item1 = name
            runList.AddRange(personText.Item2); // item2 = adresseif (!dicPersons.ContainsKey(key)) 
            if (!dicPersons.ContainsKey(key)) dicPersons.Add(key, new List<Paragraph>());
            if (!grolTextSet)
            {
              var text = new Text($"{GetGROLText(key)}" + " ")
              { Space = SpaceProcessingModeValues.Preserve };
              grolTextSet = true;
              runList.Insert(0, new Run(text));
              einzugErsteLinie = "424";
              einzugHaengend = "424";
            }

            var para = new Paragraph(runList.ToArray());
            var paraprop = new ParagraphProperties();
            var indent = new Indentation() { Left = einzug, Hanging = einzugHaengend, FirstLine = einzugErsteLinie };
            paraprop.Append(indent);
            para.Append(paraprop);

            dicPersons[key].Add(para);

          }
        });

        foreach (var key in dicGS.Keys)
        {
          string einzug = "424";
          string prepend = $"{GetGROLText(key)}" + (nrText && !string.Join(", ", dicGS[key]).Contains("s.u.d") ? " Nr." : "");
          if (prepend.Contains("Nr"))
          {
            einzug = "707";
            if (prepend.Contains("+")) einzug = "1274";
          }
          else if (prepend.Contains("+")) einzug = "951";

          foreach (var y in dicGS[key])
          {
            y.Insert(0, new Run(new Text(prepend + " ") { Space = SpaceProcessingModeValues.Preserve }));
            var p = new Paragraph(y.ToArray());
            var indent = new Indentation() { Left = einzug };
            var paraprop = new ParagraphProperties();
            paraprop.Append(indent);
            if (!String.IsNullOrEmpty(prepend)) indent.Hanging = einzug;
            result.Add(p);
            prepend = " ";
          }
          if (dicPersons.ContainsKey(key)) // wenn es dazu Personen hat, anzeigen
          {
            result.AddRange(dicPersons[key]);
          }
        }
      }
      return result;
    }

    private Tuple<List<Run>, List<Run>> GetPersonText(Person person)
    {
      switch (person.Typ)
      {
        default:
        case "N":
          {
            //ledigername immer
            var ledigerName = person.LedigName;
            if (!string.IsNullOrEmpty(ledigerName))
            {
              ledigerName = $"-{ledigerName}";
            }
            List<Run> namenList = new List<Run>();

            var vornamen = person.Vorname.Split(' ');
            var rufnamen = person.Rufname.Split(' ');

            namenList.Add(new Run(new Text($"{person.Name}{ledigerName}") { Space = SpaceProcessingModeValues.Preserve }));
            Text t = new Text();
            foreach (var vorname in vornamen)
            {
              var runBlank = new Run(new Text(" ") { Space = SpaceProcessingModeValues.Preserve }); // das Blank separat machen, da es sonst auch unterstrichen wird
              namenList.Add(runBlank);
              bool underline = rufnamen.Contains(vorname);
              var run = new Run(new Text(vorname));
              namenList.Add(run);
            }
            var name = $"{person.Name}{ledigerName} {person.Vorname}";

            var ort = "";
            if (!String.IsNullOrEmpty(person.Geburtsort)) ort += $", von {person.Geburtsort}";
            if (!String.IsNullOrEmpty(person.Nationalitaet)) ort += $", Staatsangehörigkeit: { person.Nationalitaet }";

            var plz = person.Plz;
            var land = "";
            if (!String.IsNullOrEmpty(person.Land) && person.Land != "CH" && person.Land != "Schweiz")
            {
              //vor plz ländercode
              plz = person.Land + "-" + plz;
              //land in klammern am schluss N CH
              land = $" ({person.Laenderkürzel})";
            }

            if (!String.IsNullOrEmpty(plz)) plz += " ";

            //N: wohnhaft in eigentümer -> land egal
            var strasse = ", " + person.Strasse;
            var text = "";
            text = $", geb. {person.Geburtsdatum}{ort}{strasse}, {plz}{person.Ort}{land}";
            List<Run> adressListe = new List<Run>
                        {
                            new Run(new Text(text))
                        };
            return new Tuple<List<Run>, List<Run>>(namenList, adressListe);
          }
        case "G":
          {
            var name = new Run(new Text(person.Name));
            var rform = "";
            rform = person.Rechtsform;

            var detail = ", " + String.Join(", ", new List<string> { rform, person.Strasse, person.Plz + " " + person.Ort }.Where(i => !String.IsNullOrWhiteSpace(i)));
            if (detail == ", ")
            {
              detail = "";
            }

            Run detailRun = new Run(new Text(detail));

            return new Tuple<List<Run>, List<Run>>(new List<Run>() { name }, new List<Run>() { detailRun });
          }
        case "J":
          {
            var name = new Run(new Text(person.Name));
            var sitz = "";
            var rechtsForm = "";

            sitz = $"mit Sitz in { person.Sitz}";
            rechtsForm = $"{person.Rechtsform}";


            var detailText = ", " + String.Join(", ", new List<string> { sitz, rechtsForm, person.Strasse, person.Plz + " " + person.Ort }.Where(i => !String.IsNullOrWhiteSpace(i)));
            if (detailText == ", ")
            {
              detailText = "";
            }

            var detailRun = new Run(new Text(detailText));
            return new Tuple<List<Run>, List<Run>>(new List<Run>() { name }, new List<Run>() { detailRun });
          }
      }
    }

    private string GetGROLText(string input)
    {
      switch (input)
      {
        case "R":
          return "z.G. + z.L.";
        case "D":
          return "z.G.";
        case "S":
          return "z.L.";
        case "B":
          return "Verselbständigt als Grundstück";
      }
      return "";
    }

    private string GetGSNummer(Grundstück gs, string rootKreis)
    {
      if (gs == null) return null;
      return GetGSNummer(gs.GrundstückIdMitGrundbuch, rootKreis);
    }

    private string GetGSNummer(string gsNummer, string rootKreis)
    {
      string rootKreisBezeichnung;
      Grundbuchkreise kreise = new Grundbuchkreise();
      rootKreisBezeichnung = kreise.kreisBezeichnungHerleiten(rootKreis);
      if (gsNummer == null || rootKreisBezeichnung == null) return null;
      if (gsNummer.Contains(rootKreisBezeichnung))
      {
        int start = gsNummer.IndexOf(rootKreisBezeichnung) - 1;
        return gsNummer.Remove(start);
      }

      return gsNummer;
    }

    private List<Paragraph> BuildRechteBelege(Dienstbarkeit dienstbarkeit)
    {
      var result = new List<Paragraph>();
      foreach (var beleg in dienstbarkeit.Belege.Where(i => i.Status == "R" && (IsBeleg(i))).OrderBy(i => i.DatumFormatEu).ThenBy(i => i.NummerMitWhitespace).ThenBy(i => i.Status))
      {
        {
          string belegText = GetBelegText(beleg);
          result.Add(new Paragraph(new Run(new Text(belegText))));
        }
      }
      return result;
    }

    private bool IsBeleg(Belege beleg)
    {
      return IsBeleg(beleg.NummerMitWhitespace);
    }

    private bool IsBeleg(string nr)
    {
      Regex r = new Regex("\\s[(].*[)]$");
      Match m = r.Match(nr);
      if (m.Length > 0)
      {
        nr = nr.Replace(m.Value, "");
      }

      //           ~               Nummern, die mit 2 Buchstaben enden                     Nummern die mit 2 Zahlen enden
      return nr.Contains("~") || nr.Substring(nr.Length - 2).All(i => Char.IsLetter(i)) || nr.Substring(nr.Length - 2).All(i => !Char.IsLetter(i));

    }

    private string GetBelegText(Belege beleg, bool date = true)
    {
      string belegText = "";
      if (IsBeleg(beleg))
      {
        if (date && !string.IsNullOrEmpty(beleg.DatumFormatEu) && DateTime.Parse(beleg.DatumFormatUsa) > DateTime.MinValue.AddYears(1000))
        {
          belegText += DateTime.Parse(beleg.DatumFormatUsa).ToString("dd.MM.yyyy") + " ";
        }

        if (!beleg.NummerOhneWhitespace.Contains("BH"))
        {
          belegText += $"Beleg ";
        }
        belegText += $"{beleg.NummerOhneWhitespace}";
      }
      else
      {
        belegText = $"Geschäft {beleg.NummerOhneWhitespace}";
      }

      return belegText;
    }

  }
}
