namespace ClassLibrary1
{
    public class AutopropertyEnhancementBefore
    {
        public class Customer
        {
            public string First { get; set; }
            public string Last { get; set; }

            public Customer()
            {
                First = "David";
                Last = "Whitney";
            }
        }
    }
}
