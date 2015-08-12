using System;

namespace ClassLibrary1
{
    public class ExceptionFilters
    {
        public ExceptionFilters()
        {
            try
            {
                throw new Exception("abc");
            }
            catch (Exception ex) when (ex.Message == "def")
            {
                // Log
            }
        }
    }
}