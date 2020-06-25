using System;
using System.Security.Policy;

namespace Ex1.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message)
        {

        }

    }
}
