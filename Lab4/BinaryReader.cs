namespace Lab4Main
{
    public class BinaryReader
    {
        public string Read(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
