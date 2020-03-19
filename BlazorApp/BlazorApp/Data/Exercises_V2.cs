using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
     public class Exercises_V2
     {
          public int Id { get; set; }
          public string Exercise { get; set; }
          public string Solution { get; set; }
          public string VarableData { get; set; }
          public string ExerciseLevel { get; set; }
          public string ProjectType { get; set; }
          public string Langues { get; set; }
          public string ExpectedSolution { get; set; }
          public DateTime PostedDate { get; set; }
          public DateTime ModifiedDate { get; set; }

          public Exercises_V2()
          {

          }


          public Exercises_V2(int id, string exercise, string solution, string varableData, string exerciseLevel, string projectType, string langues, string expectedSolution, DateTime postedDate, DateTime modifiedDate)
          {
               Id = id;
               Exercise = exercise;
               Solution = solution;
               VarableData = varableData;
               ExerciseLevel = exerciseLevel;
               ProjectType = projectType;
               Langues = langues;
               ExpectedSolution = expectedSolution;
               PostedDate = postedDate;
               ModifiedDate = modifiedDate;
          }

          public void clear()
          {
               Id = 0;
               Exercise = "";
               Solution = "";
               VarableData = "";
               ExerciseLevel = "";
               ProjectType = "";
               Langues = "";
               ExpectedSolution = "";
               PostedDate = new DateTime();
               PostedDate = new DateTime();
          }
     }
}
