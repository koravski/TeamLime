using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuGiOh
{
    public class InternalGameException : ApplicationException
    {
        public InternalGameException(string message)
            : base(message)
        {
        }
    }
}
