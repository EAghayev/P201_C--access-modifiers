using System;
using System.Collections.Generic;
using System.Text;

namespace _03112021.Exceptions
{
    class InvalidCarYearException:Exception
    {
        public InvalidCarYearException(string? msg):base(msg)
        {

        }
    }
}
