using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Exceptions
{
    class IncorrectIsbn13Exception:Exception
    {
        public IncorrectIsbn13Exception() : base("Isbn13 must be exactly 13 characters long.")
        {

        }

        public IncorrectIsbn13Exception(string message) : base(message)
        {

        }

        public IncorrectIsbn13Exception(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
