using System.IO;
using System.Linq;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace AdapterWinForms.Documents
{
    
    public class WordDocument
    {
        private readonly string _path;
        public WordDocument(string path) { _path = path; }

        public string ReadDocument()
        {
            if (!File.Exists(_path)) return string.Empty;
            using (WordprocessingDocument doc = WordprocessingDocument.Open(_path, false))
            {
                if (doc.MainDocumentPart == null || doc.MainDocumentPart.Document == null)
                    return string.Empty;
                return string.Join(System.Environment.NewLine,
                    doc.MainDocumentPart.Document.Descendants<Paragraph>()
                    .Select(p => string.Concat(p.Descendants<Text>().Select(t => t.Text))));
            }
        }

        public void SaveDocument(string text)
        {
            string dir = Path.GetDirectoryName(_path);
            if (!string.IsNullOrEmpty(dir)) Directory.CreateDirectory(dir);
            using (WordprocessingDocument doc = WordprocessingDocument.Create(
                _path, WordprocessingDocumentType.Document))
            {
                MainDocumentPart main = doc.AddMainDocumentPart();
                main.Document = new Document(new Body());
                string value = text ?? string.Empty;
                string[] lines = value.Replace("\r\n", "\n").Replace('\r', '\n').Split('\n');
                foreach (string line in lines)
                    main.Document.Body.AppendChild(new Paragraph(new Run(new Text(line)
                    { Space = SpaceProcessingModeValues.Preserve })));
                main.Document.Save();
            }
        }
    }
}
