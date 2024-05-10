using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT
{
    public class TwoDigitNumberException : Exception
    {
        public TwoDigitNumberException()
        {
        }

        public TwoDigitNumberException(string message)
            : base(message)
        {
        }

        public TwoDigitNumberException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
