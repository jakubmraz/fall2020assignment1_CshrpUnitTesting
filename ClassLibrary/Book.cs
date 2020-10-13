using System;
using ClassLibrary.Exceptions;

namespace ClassLibrary
{
    public class Book
    {
        private string _title;
        private string _author;
        private int _pageNumber;
        private string _isbn13;

        public Book(string title, string author, int pageNumber, string isbn13)
        {
            this.Title = title;
            this.Author = author;
            this.PageNumber = pageNumber;
            this.Isbn13 = isbn13;
        }

        public Book()
        {

        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = CheckTitle(value);
            }
        }
        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
            }
        }
        public int PageNumber
        {
            get
            {
                return _pageNumber;
            }
            set
            {
                _pageNumber = CheckPageNumber(value);
            }
        }
        public string Isbn13
        {
            get
            {
                return _isbn13;
            }
            set
            {
                _isbn13 = CheckIsbn13(value);
            }
        }

        private string CheckTitle(string title)
        {
            if (title.Length >= 2)
                return title;
            throw new TitleTooShortException();
        }

        private int CheckPageNumber(int pageNumber)
        {
            if (pageNumber > 10 && pageNumber <= 1000)
                return pageNumber;
            throw new UnsupportedPageNumberException();
        }

        private string CheckIsbn13(string isbn13)
        {
            if (isbn13.Length == 13)
                return isbn13;
            throw new IncorrectIsbn13Exception();
        }
    }
}
