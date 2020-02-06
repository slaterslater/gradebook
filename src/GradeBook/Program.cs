using System;

namespace GradeBook
{

  class Program
  {
    static void Main(string[] args)
    {
      var book = new Book("February 2020");
      string input;
      Console.WriteLine("Enter grades or Q to exit");
      do{
        input = Console.ReadLine();
       try {
          var grade = double.Parse(input);
          book.AddGrade(grade);
        } catch (ArgumentException err){
          Console.WriteLine(err.Message);
        } catch(FormatException){
          Console.WriteLine("Not a number");
        }
      } while (!String.Equals("Q",input.ToUpper()));
      book.DisplayStats();
    }
  }
}
