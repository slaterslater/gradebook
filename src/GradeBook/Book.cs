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

    public List<double> GetGrades(){
      return grades;
    }

    public Statistics GetStatistics(){
      return new Statistics(GetGrades());
    }

    public void DisplayStats(){
      var stats = GetStatistics();
      Console.WriteLine($"Grades for {name}");
      Console.WriteLine($"Top Grade: {stats.max}");
      Console.WriteLine($"Low Grade: {stats.min}");
      Console.WriteLine($"Average : {stats.avg}");
    }

  }


}