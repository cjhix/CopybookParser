namespace CopybookParser
{
    internal sealed class FieldVisitor : Cobol85BaseVisitor<Field>
    {
        private string _level;
        private string _name;
        private string _usage;
        private string _picClause;

        public override Field VisitDataDescriptionEntry(Cobol85Parser.DataDescriptionEntryContext context)
        {
            return VisitChildren(context);
        }

        public override Field VisitDataDescriptionEntryFormat1(Cobol85Parser.DataDescriptionEntryFormat1Context context)
        {
            _level = context.INTEGERLITERAL().ToString();
            _name = context.dataName().GetText();
            
            var ducVisitor = new DataUsageClauseVisitor();
            _usage = ducVisitor.VisitDataUsageClause(context.dataUsageClause(0));

            var psVisitor = new PictureStringVisitor();
            _picClause = psVisitor.VisitPictureString(context.dataPictureClause(0).pictureString());
            
            return new Field
            {
                Level = _level,
                Name = _name,
                Usage = _usage,
                PicClause = _picClause
            };
        }
    }
}