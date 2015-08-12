using System.Collections.Generic;

namespace ClassLibrary1
{
    public class IndexInitializers
    {
        public IndexInitializers()
        {
            var numbers = new Dictionary<int, string>
            {
                [7] = "seven",
                [9] = "nine",
                [13] = "thirteen"
            };
        }
    }
}