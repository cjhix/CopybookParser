using Antlr4.Runtime;

namespace CopybookParser
{
    public sealed class Parser
    {
        public Copybook Parse(string file)
        {
            var inputStream = new AntlrFileStream(file);
            var lexer = new Cobol85Lexer(inputStream);
            var commonTokenStream = new CommonTokenStream(lexer);
            var parser = new Cobol85Parser(commonTokenStream);

            var visitor = new CopybookVisitor();
            return visitor.Visit(parser.dataDescriptionEntry());
        }
    }
}