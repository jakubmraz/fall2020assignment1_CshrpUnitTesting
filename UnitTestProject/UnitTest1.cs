using System;
using ClassLibrary;
using ClassLibrary.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(TitleTooShortException))]
        public void TestBookTitleException()
        {
            //Arrange
            Book book = new Book();
            //Act
            book.Title = "E";
            //Assert
            Assert.AreEqual("E", book.Title);
        }

        [DataTestMethod]
        [ExpectedException(typeof(UnsupportedPageNumberException))]
        [DataRow(8)]
        [DataRow(2000)]
        public void TestPageNumberTooShortException(int number)
        {
            //Arrange
            Book book = new Book();
            //Act
            book.PageNumber = number;
            //Assert
            Assert.AreEqual(number, book.PageNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(IncorrectIsbn13Exception))]
        public void TestWrongIsbn13Exception()
        {
            //Arrange
            Book book = new Book();
            //Act
            book.Isbn13 = "aasfafsd";
            //Assert
            Assert.AreEqual("aasfafsd", book.Isbn13);
        }

        [TestMethod]
        public void TestConstructor()
        {
            //Arrange
            Book book = new Book("Diary of a Wimpy Kid", "Jeff Kinney", 221, "9780143303831");
            //Act
            //Assert
            Assert.IsInstanceOfType(book, typeof(Book));
        }

        //Only checks for the first one, since if it throws an exception, it means the constructor is working as it should
        //and they don't all need to be tested individually
        [TestMethod]
        [ExpectedException(typeof(TitleTooShortException))]
        public void TestConstructorException()
        {
            //Arrange
            Book book = new Book("E", "Obama", 10, "Obamium");
            //Act
            //Assert
            Assert.IsInstanceOfType(book, typeof(Book));
        }
    }
}
