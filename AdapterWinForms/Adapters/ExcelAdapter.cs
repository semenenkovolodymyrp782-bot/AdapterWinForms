using AdapterWinForms.Documents;

namespace AdapterWinForms.Adapters
{
    public class ExcelAdapter : ITextAdapter
    {
        private readonly ExcelDocument _document;
        public ExcelAdapter(string path) { _document = new ExcelDocument(path); }
        public string ReadText() { return _document.ReadCells(); }
        public void WriteText(string text) { _document.SaveCells(text); }
    }
}
