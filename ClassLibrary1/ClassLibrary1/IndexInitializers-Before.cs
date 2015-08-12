using System.Collections.Generic;

namespace ClassLibrary1
{
    public class IndexInitializersBefore
    {
        public IndexInitializersBefore()
        {
            var numbers = new Dictionary<int, string>();
            numbers[7] = "seven";
            numbers[9] = "nine";
            numbers[13] = "thirteen";
        }
    }
}
