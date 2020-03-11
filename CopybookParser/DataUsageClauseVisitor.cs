namespace CopybookParser
{
    public sealed class DataUsageClauseVisitor : Cobol85BaseVisitor<string>
    {
        public override string VisitDataUsageClause(Cobol85Parser.DataUsageClauseContext context)
        {
            return context.GetText();
        }
    }
}