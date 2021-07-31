using System;

namespace TruckersMP.Net.Exceptions
{
    public class RequestException : Exception
    {
        public RequestException(string message = null)
            : base(message)
        {
        }
    }
}