﻿using System;

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
        double grade;
       try {
          if(double.TryParse(input, out grade))
            book.AddGrade(grade);
          else 
            book.AddGrade(input);
        } catch (ArgumentException err){
            Console.WriteLine(err.Message);
        }
      } while (!String.Equals("Q",input.ToUpper()));
      book.DisplayStats();
    }
  }
}
