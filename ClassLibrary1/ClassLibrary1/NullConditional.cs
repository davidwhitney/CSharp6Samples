using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class NullConditionalBefore
    {
        public NullConditionalBefore()
        {
            var list = new List<MyClass>();

            int? length = null;
            MyClass first = null;
            if (list != null)
            {
                length = list.Count;
                first = list[0];  // null if customers is null
            }

        }

        public void NullConditional()
        {
            var list = new List<MyClass>();
            int? length = list?.Count;
            var first = list?[0];
        }
    }

    public class MyClass { }
}
