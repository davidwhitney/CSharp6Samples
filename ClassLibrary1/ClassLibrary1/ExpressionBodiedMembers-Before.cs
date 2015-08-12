using System;

namespace ClassLibrary1
{
    public class ExpressionBodiedMembersBefore
    {
        public class Customer
        {
            public string First { get; set; }
            public string Last { get; set; }
            public string FullName { get { return First + " " + Last; } }

            public Customer()
            {
                First = "David";
                Last = "Whitney";
            }

            public void Print()
            {
                Console.WriteLine(FullName);
            }
        }
    }
}
