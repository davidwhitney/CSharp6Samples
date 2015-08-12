using static ClassLibrary1.UsingStaticHelpers.StaticCustomerHelpers;

namespace ClassLibrary1
{
    public class Customer
    {
        public string Name { get; } = "David";
    }

    public class UsingStaticUsedLikeMixins
    {
        public void DoSomethingWithCustomer()
        {
            var myCustomer = new Customer();
            PrintCustomer(myCustomer);
        }
    }
}
