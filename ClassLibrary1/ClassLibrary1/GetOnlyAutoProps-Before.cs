namespace ClassLibrary1
{
    public class GetOnlyAutoPropsBefore
    {
        public class Customer
        {
            private string _first;
            private string _last;

            public string First { get { return _first; } }
            public string Last { get { return _last; } }

            public Customer()
            {
                _first = "David";
                _last = "Whitney";
            }
        }
    }
}
