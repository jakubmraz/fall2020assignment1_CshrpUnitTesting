using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Exceptions
{
    class TitleTooShortException:Exception
    {
        public TitleTooShortException() : base("Title must be longer than 2 characters.")
        {

        }

        public TitleTooShortException(string message) : base(message)
        {

        }

        public TitleTooShortException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
