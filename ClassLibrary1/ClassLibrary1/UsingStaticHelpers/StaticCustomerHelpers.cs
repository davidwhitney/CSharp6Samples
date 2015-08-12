using System;

namespace ClassLibrary1.UsingStaticHelpers
{
    public static class StaticCustomerHelpers
    {
        public static void PrintCustomer(Customer customer)
        {
            Console.WriteLine(customer.Name);
        }
    }
}
