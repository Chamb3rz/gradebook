using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {

        [Fact]
        public void NewTest()
        {
            var x = GetInt();
            SetInt(x);

            Assert.Equal(x, 3);
        }

        private void SetInt(int x)
        {
            x = 43;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");

            Assert.Equal(book1.Name, "New Name");
        }

        private void GetBookSetName(ref Book book, string name)
        {
           book = new Book(name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal(book1.Name, "Book 1");
        }

        private void GetBookSetName(Book book, string name)
        {
           book = new Book(name);
        }

        [Fact]
        public void canSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal(book1.Name, "New Name");
        }

        private void SetName(Book book, string name)
        {
           book.Name = name; 
        }

        [Fact]
        public void StringBehaveLikeValueType()
        {
            string name = "Jake";
            string upper = MakeUpper(name);

            Assert.Equal(name, "Jake");
            Assert.Equal(upper, "JAKE");
        }

        private string MakeUpper(string name)
        {
            return name.ToUpper();
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVariablesCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}