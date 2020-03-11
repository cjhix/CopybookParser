using System;
using System.Linq;

namespace CopybookParser
{
    internal sealed class CopybookVisitor : Cobol85BaseVisitor<Copybook>
    {
        private string _level;
        private string _name;

        public override Copybook VisitDataDescriptionEntry(Cobol85Parser.DataDescriptionEntryContext context)
        {
            return VisitChildren(context);
        }

        public override Copybook VisitDataDescriptionEntryFormat1(Cobol85Parser.DataDescriptionEntryFormat1Context context)
        {
            Console.WriteLine($"{context.INTEGERLITERAL()} {context.dataName().GetText()}");
            
            _level = context.INTEGERLITERAL().ToString();
            _name = context.dataName().GetText();
            
            return new Copybook
            {
                Level = _level,
                Name = _name
            };
        }
    }
}
