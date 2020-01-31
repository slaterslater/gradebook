using System;
using Xunit;

namespace GradeBook.Tests
{
  public class TypeTests
  {
    [Fact]
    public void Test1()
    {
      var x = GetInt();
      SetInt(ref x);

      Assert.Equal(42, x);
    }

    private void SetInt(ref int x)
    {
      x = 42;
    }

    private int GetInt()
    {
      return 2;
    }

    [Fact]
    public void GetBookReturnsDifferentObjects()
    {
      var book1 = GetBook("Book 1");
      var book2 = GetBook("Book 2");

      Assert.Equal("Book 1", book1.GetName());
      Assert.Equal("Book 2", book2.GetName());
    }

    [Fact]
    public void TwoVarsCanReferenceSameObject()
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
