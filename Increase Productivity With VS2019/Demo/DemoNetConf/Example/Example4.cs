namespace DemoNetConf.Example
{
    public class Example4
    {
        public string ReplaceComma(string str)
        {
            return str.TrimStart().TrimEnd().Replace(',', '.');
        }
    }
}
