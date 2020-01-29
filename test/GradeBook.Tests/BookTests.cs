using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
          // arrage
          var book = new Book("");
          book.AddGrade(67.9);
          book.AddGrade(75.4);
          book.AddGrade(88.1);

          // act
          var avg = book.AverageGrade();
          
          // assert
          Assert.Equal("77.13", $"{avg:N2}");
        }
    }
}
