using AdapterWinForms.Documents;

namespace AdapterWinForms.Adapters
{
    
    public class WordAdapter : ITextAdapter
    {
        private readonly WordDocument _document;
        public WordAdapter(string path) { _document = new WordDocument(path); }
        public string ReadText() { return _document.ReadDocument(); }
        public void WriteText(string text) { _document.SaveDocument(text); }
    }
}
