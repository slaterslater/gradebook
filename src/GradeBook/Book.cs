using System;
using System.Collections.Generic;

namespace GradeBook
{
  public class Book
  {
    private List<double> grades;
    private string name;

    public Book(string name){
      this.name = name;
      grades = new List<double>();
    }
    
    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }

    public double AverageGrade()
    {
      var result = 0.0;
      foreach (double number in grades)
      {
        result += number;
      }
      result /= grades.Count;
      return result;
    }

    public double MaxGrade(){
      var max = double.MinValue;
      foreach (var number in grades)
      {
        max = Math.Max(number, max);
      }
      return max;
    }
    
    public double MinGrade(){
      var min = double.MaxValue;
      foreach (var number in grades)
      {
        min = Math.Min(number, min);
      }
      return min;
    }

    public void ShowAllStats(){
      Console.WriteLine($"avg={AverageGrade()}\ntop={MaxGrade()}\nlow={MinGrade()}");
    }

  }


}