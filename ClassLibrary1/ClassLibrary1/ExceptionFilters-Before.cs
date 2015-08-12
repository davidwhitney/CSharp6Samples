using System;

namespace ClassLibrary1
{
    public class ExceptionFiltersBefore
    {
        public ExceptionFiltersBefore()
        {
            try
            {
                throw new Exception("abc");
            }
            catch (Exception ex)
            {
                if (ex.Message == "def")
                {
                    // Log
                }
                else
                {
                    /// log something else
                    throw;
                }
            }
        }
    }
}
