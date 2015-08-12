using System;

namespace ClassLibrary1
{
    class ExpressionBodiedMembers
    {
        public class Customer
        {
            public string First { get; set; }
            public string Last { get; set; }
            public string FullName => First + " " + Last;
            public void Print() => Console.WriteLine(FullName);

            public Customer()
            {
                First = "David";
                Last = "Whitney";
            }
        }

        public class CombinedWithAutoPropEnhancements
        {
            public string First { get; set; } = "David";
            public string Last { get; set; } = "Whitney";
            public string FullName => First + " " + Last;
            public void Print() => Console.WriteLine(FullName);
        }
    }
}
