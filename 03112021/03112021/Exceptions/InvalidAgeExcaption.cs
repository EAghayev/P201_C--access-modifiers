using System;
using System.Collections.Generic;
using System.Text;

namespace _03112021.Exceptions
{
    class InvalidAgeExcaption:Exception
    {
        public InvalidAgeExcaption(string msg):base(msg)
        {

        }
    }
}
