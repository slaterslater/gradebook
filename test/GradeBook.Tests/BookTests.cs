using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesStats()
        {
          // arrage
          var book = new Book("");
          book.AddGrade(67.9);
          book.AddGrade(75.4);
          book.AddGrade(88.1);

          // act
          var stats = book.GetStatistics();
          
          // assert
          Assert.Equal(77.1, stats.avg, 1);
          Assert.Equal(88.1, stats.max, 1);
          Assert.Equal(67.9, stats.min, 1);
        }
    }
}
