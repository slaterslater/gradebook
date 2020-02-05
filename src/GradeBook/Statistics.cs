using System;
using System.Collections.Generic;

namespace GradeBook{
  
  public class Statistics{

    public double max;
    public double min;
    public double avg;
    public string letter;

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
      switch(avg){
        case double avg when avg >= 90.0:
          letter = "A+";
          break;
        case double avg when avg >= 80.0:
          letter = "A";
          break;
        case double avg when avg >= 75.0:
          letter = "B+";
          break;
        case double avg when avg >= 70.0:
          letter = "B";
          break;
        case double avg when avg >= 65.0:
          letter = "C+";
          break;
        case double avg when avg >= 60.0:
          letter = "C";
          break;
        case double avg when avg >= 55.0:
          letter = "D+";
          break;
        case double avg when avg >= 50.0:
          letter = "D";
          break;
        default:
          letter = "F";
          break;
      }
    }

  }
}