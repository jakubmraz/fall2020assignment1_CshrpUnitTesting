using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Exceptions
{
    public class UnsupportedPageNumberException:Exception
    {
        public UnsupportedPageNumberException() : base("Page number must be greater than 10 and less or equal than 1000.")
        {

        }
    }
}
