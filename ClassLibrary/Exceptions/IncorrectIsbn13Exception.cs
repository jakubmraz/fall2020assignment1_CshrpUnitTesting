using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Exceptions
{
    public class IncorrectIsbn13Exception:Exception
    {
        public IncorrectIsbn13Exception() : base("Isbn13 must be exactly 13 characters long.")
        {

        }
    }
}
