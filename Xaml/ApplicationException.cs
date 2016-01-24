using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xaml
{
    public class ApplicationException : Exception
    {
        public ApplicationException(string message) : base(message)
        {
        }
    }
}
