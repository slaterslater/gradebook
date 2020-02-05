using System;

namespace GradeBook
{

  class Program
  {
    static void Main(string[] args)
    {
      var book = new Book("February 2020");
      var input = "";
      Console.WriteLine("Enter grades or Q to exit");
      do{
        input = Console.ReadLine();
        double grade;
        if(double.TryParse(input, out grade))
          book.AddGrade(grade);
      } while (!String.Equals("Q",input.ToUpper()));
      
      

      book.DisplayStats();
    }
  }
}
