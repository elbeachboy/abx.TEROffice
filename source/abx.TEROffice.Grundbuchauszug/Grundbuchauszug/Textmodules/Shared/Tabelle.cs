using System;
using System.Collections.Generic;
using System.Text;
using abx.TEROffice.DataReader.Businessmodel.Dienstbarkeiten;
using abx.TEROffice.DocumentProcessing.Grundbuchauszug.Textmodules.Interfaces;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;

namespace abx.TEROffice.DocumentProcessing.Grundbuchauszug.Textmodules.Shared
{
    public class Tabelle : ITextbaustein
    {
        private Paragraph _tabelle;
        public Tabelle(DataReader.Businessmodel.Grundbuchauszug auszug)
        {
            _tabelle = new Paragraph();
            Run run = new Run();
            Table table = new Table();


            var columnOne = "2269";
            var columnTwo = "4722";
            var columnThree = "2109";

            TableProperties tableProperties = new TableProperties();
            TableStyle tableStyle = new TableStyle() { Val = "Tabellenraster" };
            TableWidth tableWidth = new TableWidth() { Width = "9100", Type = TableWidthUnitValues.Dxa };
            TableLook tableLook = new TableLook() { Val = "04A0", FirstRow = true, LastRow = false, FirstColumn = true, LastColumn = false, NoHorizontalBand = false, NoVerticalBand = true };

            TableBorders tableBorder = new TableBorders(); TableBorders tableBorders1 = new TableBorders();
            tableBorder.Append(new TopBorder() { Val = BorderValues.None, Color = "auto", Size = 0U, Space = 0U });
            tableBorder.Append(new LeftBorder() { Val = BorderValues.None, Color = "auto", Size = 0U, Space = 0U });
            tableBorder.Append(new BottomBorder() { Val = BorderValues.None, Color = "auto", Size = 0U, Space = 0U });
            tableBorder.Append(new RightBorder() { Val = BorderValues.None, Color = "auto", Size = 0U, Space = 0U });
            tableBorder.Append(new InsideHorizontalBorder() { Val = BorderValues.None, Color = "auto", Size = 0U, Space = 0U });
            tableBorder.Append(new InsideVerticalBorder() { Val = BorderValues.None, Color = "auto", Size = 0U, Space = 0U });

            tableProperties.Append(tableStyle);
            tableProperties.Append(tableWidth);
            tableProperties.Append(tableLook);
            tableProperties.Append(tableBorder);
            tableProperties.Append(new TableLayout() { Type = TableLayoutValues.Fixed });

            TableCellMarginDefault tableCellMarginDefault = new TableCellMarginDefault();
            tableCellMarginDefault.Append(new TableCellLeftMargin() { Width = 45, Type = TableWidthValues.Dxa });
            tableCellMarginDefault.Append(new TableCellRightMargin() { Width = 45, Type = TableWidthValues.Dxa });
            tableCellMarginDefault.Append(new BottomMargin() { Width = "200", Type = TableWidthUnitValues.Dxa });
            tableCellMarginDefault.Append(new TopMargin() { Width = "45", Type = TableWidthUnitValues.Dxa });
            tableProperties.Append(tableCellMarginDefault);

            table.Append(tableProperties);

            TableGrid tableGrid = new TableGrid();
            tableGrid.Append(new GridColumn() { Width = columnOne });
            tableGrid.Append(new GridColumn() { Width = columnTwo });
            tableGrid.Append(new GridColumn() { Width = columnThree });
            table.Append(tableGrid);

            var headerRow = new TableRow();
            headerRow.Append(new TableCell(new Paragraph(new Run(new Text("Reg-Nr.")))));
            headerRow.Append(new TableCell(new Paragraph(new Run(new Text("Stichwort")))));
            tableGrid.Append(headerRow);

            foreach (var dbk in auszug.Dienstbarkeiten)
            {
                Zeile row = new Zeile(dbk, auszug, columnOne, columnTwo, columnThree);
                tableGrid.Append(row.GetZeile());
            }


            run.AppendChild(table);
            _tabelle.AppendChild(run);
        }

        public Paragraph GetParagraph()
        {
            return this._tabelle;
        }

    }
}
