using System.Collections.Generic;

using CopybookParser;

namespace CopybookParser
{
    public sealed class Copybook
    {
        public string Level { get; set; }
        public string Name { get; set; }
        public List<Field> Fields { get; }
    }
}