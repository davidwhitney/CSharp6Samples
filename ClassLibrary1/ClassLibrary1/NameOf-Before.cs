using System;

namespace ClassLibrary1
{
    public class NameOfBefore
    {
        public NameOfBefore(string param)
        {
            throw new ArgumentException("Arg is null!", "param");
        }
    }
}
