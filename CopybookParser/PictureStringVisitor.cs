namespace CopybookParser
{
    public sealed class PictureStringVisitor : Cobol85BaseVisitor<string>
    {
        public override string VisitPictureString(Cobol85Parser.PictureStringContext context)
        {
            return context.GetText();
        }
    }
}