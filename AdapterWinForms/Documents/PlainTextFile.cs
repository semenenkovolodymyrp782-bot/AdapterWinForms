using System.IO;
using System.Text;

namespace AdapterWinForms.Documents
{
  
    public class PlainTextFile
    {
        private readonly string _path;

        public PlainTextFile(string path) { _path = path; }

        public string ReadFile()
        {
            if (!File.Exists(_path)) return string.Empty;
            return File.ReadAllText(_path, Encoding.UTF8);
        }

        public void WriteFile(string text)
        {
            string directory = Path.GetDirectoryName(_path);
            if (!string.IsNullOrEmpty(directory)) Directory.CreateDirectory(directory);
            File.WriteAllText(_path, text ?? string.Empty, new UTF8Encoding(false));
        }
    }
}
