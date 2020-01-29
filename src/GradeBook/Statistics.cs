using System;
using System.Collections.Generic;

namespace GradeBook{
  
  public class Statistics{

    public double max;
    public double min;
    public double avg;

    public Statistics(List<double> grades){
      max = double.MinValue;
      min = double.MaxValue;
      avg = 0.0;
      foreach(double grade in grades){
        max = Math.Max(grade, max);
        min = Math.Min(grade, min);
        avg += grade;
      }
      avg/= grades.Count;
    }

  }
}