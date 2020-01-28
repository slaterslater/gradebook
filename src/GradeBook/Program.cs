using System;
using System.Collections.Generic;

namespace GradeBook
{

  class Program
  {
    static void Main(string[] args)
    {
      var book = new Book();

      List<double> grades = new List<double>() { 12.6454, 12.4767, 12.58787 };

      var result = 0.0;
      foreach (double number in grades)
      {
        result += number;
      }
      result /= grades.Count;
      Console.WriteLine($"{result:N2}");
    }
  }
}
