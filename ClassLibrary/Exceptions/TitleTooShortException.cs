using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Exceptions
{
    public class TitleTooShortException:Exception
    {
        public TitleTooShortException() : base("Title must be longer than 2 characters.")
        {

        }
    }
}
