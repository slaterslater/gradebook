using System;

namespace GradeBook
{

  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter gradebook name: ");
      var book = new Book(Console.ReadLine());
      EnterGrades(book);       
      book.DisplayStats();
    } // Main

    static void EnterGrades(Book book){
      string instr = "Enter grades or Q to exit";
      Console.WriteLine(instr);
      string input;
      int count = 0; 
      while (true) {
        Console.Write($"{++count}: ");
        input = Console.ReadLine();
        if (String.Equals("Q", input.ToUpper())){
          break;
        } else {
          double grade;
          try {
            if(String.IsNullOrEmpty(input))
              throw new ArgumentException(instr);
            else if (double.TryParse(input, out grade))
              book.AddGrade(grade);
            else
              book.AddGrade(input.ToUpper());
          }
          catch (ArgumentException err) {
            Console.WriteLine(err.Message);
            count--;
          }
        }
      }
    } // EnterGrades
  }
}
