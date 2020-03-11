using System;

internal class Listener : Cobol85BaseListener
{
    public override void EnterDataDescriptionEntryFormat1(Cobol85Parser.DataDescriptionEntryFormat1Context context)
    {
        Console.WriteLine(context.INTEGERLITERAL().ToString());
        Console.WriteLine(context.dataName().GetText());
    }
}