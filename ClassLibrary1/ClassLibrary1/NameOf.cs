using System;

namespace ClassLibrary1
{
    public class NameOf
    {
        public NameOf(string param)
        {
            throw new ArgumentException("Arg is null!", nameof(param));
        }
    }
}