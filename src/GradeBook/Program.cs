using System;

namespace GradeBook
{

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter gradebook name");
      string input = Console.ReadLine();
      var book = new Book(input);   
      Console.WriteLine("Enter grades or Q to exit");
      while (true) {
        input = Console.ReadLine();
        if (String.Equals("Q", input.ToUpper())){
          break;
        } else {
          double grade;
          try {
            if (double.TryParse(input, out grade))
              book.AddGrade(grade);
            else
              book.AddGrade(input);
          }
          catch (ArgumentException err) {
            Console.WriteLine(err.Message);
          }
        }
      }
      book.DisplayStats();
    }
  }
}
