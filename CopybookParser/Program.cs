namespace CopybookParser
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var parser = new Parser();
            var copybook = parser.Parse("copybook.cbl");
        }
    }
}
