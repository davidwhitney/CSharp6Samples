namespace ClassLibrary1
{
    public class GetOnlyAutoProps
    {
        public class Customer
        {
            public string First { get; }
            public string Last { get; }

            public Customer()
            {
                First = "David";
                Last = "Whitney";
            }
        }

        public class CombinedWithAutopropInitilisers
        {
            public string First { get; } = "David"; // Generates private readonly backing fields
            public string Last { get; } = "Whitney";
        }
    }
}
