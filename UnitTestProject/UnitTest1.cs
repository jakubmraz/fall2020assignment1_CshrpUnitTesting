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
    }
}
