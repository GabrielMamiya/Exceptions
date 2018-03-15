using System;
namespace Exceptions
{
    public class OperationException : Exception
    {
        public OperationException(string msg) : base(msg)
        {
        }
    }
}
