using System;
using System.Collections.Generic;
using System.Text;

namespace _03112021.Exceptions
{
    class InvalidCarBrandException:Exception
    {
        public InvalidCarBrandException(string? msg):base(msg)
        {

        }
    }
}
