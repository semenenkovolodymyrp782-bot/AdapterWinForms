namespace AdapterWinForms.Adapters
{
    public interface ITextAdapter
    {
        string ReadText();
        void WriteText(string text);
    }
}
