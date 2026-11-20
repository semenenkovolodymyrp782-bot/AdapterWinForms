using AdapterWinForms.Adapters;

namespace AdapterWinForms
{
    public class Client
    {
        public string TransferText(ITextAdapter adapter, string sourceText)
        {
            adapter.WriteText(sourceText);
            return adapter.ReadText();
        }
    }
}
