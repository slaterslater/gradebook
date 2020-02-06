using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookRejectsInvalidGrades(){
          var book1 = new Book("");
          try{  
            book1.AddGrade(50);
            book1.AddGrade(99);
            book1.AddGrade(102.1);
            book1.AddGrade(-2.8);       
          } catch(Exception){
            // do nothing
          }
          Assert.Equal(2,book1.GetSize());
        }
        
        [Fact]
        public void BookAcceptsLetterGrades(){
          var book = new Book("");
          try{
            book.AddGrade("A+");
            book.AddGrade("B");
            book.AddGrade("T");
          } catch (Exception){
            // do nothing
          }
          var stats = book.GetStatistics();
          Assert.Equal(80, stats.avg, 0);
        }

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
          Assert.Equal("B+", stats.letter);
        }
    }
}
