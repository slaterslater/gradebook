using System;

namespace GradeBook
{

  class Program
  {
    static void Main(string[] args)
    {
      var book = new Book("January 2020");
      book.AddGrade(75.4);
      book.AddGrade(80.2);
      book.AddGrade(88.1);
      book.AddGrade(79.9);
      book.DisplayStats();
    }
  }
}
