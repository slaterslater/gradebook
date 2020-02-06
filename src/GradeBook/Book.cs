using System;
using System.Collections.Generic;

namespace GradeBook
{
  public class Book
  {
    private List<double> grades;
    private string name;

    public Book(string name)
    {
      this.name = name;
      grades = new List<double>();
    }

    public void SetName(string name)
    {
      this.name = name;
    }

    public int GetSize()
    {
      return grades.Count;
    }

    public void AddGrade(double grade)
    {
      if (grade >= 0 && grade <= 100)
        grades.Add(grade);
      else
        throw new ArgumentException("Invalid grade");
    }

    public void AddGrade(string letter){
      switch(letter){
        case "A+":
          grades.Add(90);
          break;
        case "A":
          grades.Add(80);
          break;
        case "B+":
          grades.Add(75);
          break;
        case "B":
          grades.Add(70);
          break;
        case "C+":
          grades.Add(65);
          break;
        case "C":
          grades.Add(60);
          break;
        case "D+":
          grades.Add(55);
          break;
        case "D":
          grades.Add(50);
          break;
        case "F":
          grades.Add(0);
          break;  
        default:
          throw new ArgumentException("Letter grade not recognized");  
      }
    }

    public List<double> GetGrades()
    {
      return grades;
    }

    public string GetName()
    {
      return name;
    }

    public Statistics GetStatistics()
    {
      return new Statistics(GetGrades());
    }

    public void DisplayStats()
    {
      var stats = GetStatistics();
      Console.WriteLine($"Grades for {name}");
      Console.WriteLine($"Top Grade: {stats.max}");
      Console.WriteLine($"Low Grade: {stats.min}");
      Console.WriteLine($"Average : {stats.avg:N1}");
      Console.WriteLine($"Letter : {stats.letter}");
    }

  }


}