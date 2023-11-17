namespace Lab4Main
{
    public class BinaryPrinter
    {
        public void Print(string path, string text)
        {
            File.WriteAllText(path, text);
        }
    }
}
