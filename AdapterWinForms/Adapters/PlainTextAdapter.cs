using AdapterWinForms.Documents;

namespace AdapterWinForms.Adapters
{
    
    public class PlainTextAdapter : ITextAdapter
    {
        private readonly PlainTextFile _file;
        public PlainTextAdapter(string path) { _file = new PlainTextFile(path); }
        public string ReadText() { return _file.ReadFile(); }
        public void WriteText(string text) { _file.WriteFile(text); }
    }
}
