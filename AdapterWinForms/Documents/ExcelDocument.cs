using System.IO;
using System.Linq;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace AdapterWinForms.Documents
{
    
    public class ExcelDocument
    {
        private readonly string _path;
        public ExcelDocument(string path) { _path = path; }

        public string ReadCells()
        {
            if (!File.Exists(_path)) return string.Empty;
            using (SpreadsheetDocument doc = SpreadsheetDocument.Open(_path, false))
            {
                WorkbookPart wb = doc.WorkbookPart;
                if (wb == null || wb.Workbook.Sheets == null) return string.Empty;
                Sheet sheet = wb.Workbook.Sheets.Elements<Sheet>().FirstOrDefault();
                if (sheet == null) return string.Empty;
                WorksheetPart ws = (WorksheetPart)wb.GetPartById(sheet.Id);
                SharedStringTablePart shared = wb.SharedStringTablePart;
                var rows = ws.Worksheet.Descendants<Row>();
                var output = new System.Text.StringBuilder();
                foreach (Row row in rows)
                {
                    Cell cell = row.Elements<Cell>().FirstOrDefault();
                    string value = cell == null ? "" : cell.CellValue?.Text ?? "";
                    if (cell != null && cell.DataType != null &&
                        cell.DataType.Value == CellValues.SharedString && shared != null)
                    {
                        int index;
                        if (int.TryParse(value, out index))
                            value = shared.SharedStringTable.ElementAt(index).InnerText;
                    }
                    if (output.Length > 0) output.AppendLine();
                    output.Append(value);
                }
                return output.ToString();
            }
        }

        public void SaveCells(string text)
        {
            string dir = Path.GetDirectoryName(_path);
            if (!string.IsNullOrEmpty(dir)) Directory.CreateDirectory(dir);
            using (SpreadsheetDocument doc = SpreadsheetDocument.Create(
                _path, SpreadsheetDocumentType.Workbook))
            {
                WorkbookPart wb = doc.AddWorkbookPart();
                wb.Workbook = new Workbook();
                WorksheetPart ws = wb.AddNewPart<WorksheetPart>();
                SheetData data = new SheetData();
                ws.Worksheet = new Worksheet(data);
                Sheets sheets = wb.Workbook.AppendChild(new Sheets());
                sheets.Append(new Sheet
                {
                    Id = wb.GetIdOfPart(ws),
                    SheetId = 1,
                    Name = "Текст"
                });

                string[] lines = (text ?? "").Replace("\r\n", "\n").Replace('\r', '\n').Split('\n');
                uint rowIndex = 1;
                foreach (string line in lines)
                {
                    Row row = new Row { RowIndex = rowIndex };
                    row.Append(new Cell
                    {
                        CellReference = "A" + rowIndex,
                        DataType = CellValues.InlineString,
                        InlineString = new InlineString(new Text(line)
                        { Space = SpaceProcessingModeValues.Preserve })
                    });
                    data.Append(row);
                    rowIndex++;
                }
                ws.Worksheet.Save();
                wb.Workbook.Save();
            }
        }
    }
}
