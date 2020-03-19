using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
     public class Problem_V2
     {
          public int Id { get; set; }
          public string Title { get; set; }
          public string Solution { get; set; }
          public string SolutionLink { get; set; }
          public string Details { get; set; }
          public DateTime PostedDate { get; set; }
          public DateTime ModifiedDate { get; set; }

          public Problem_V2()
          {

          }


          public Problem_V2(int id, string title, string solution, string solutionLink, string details, DateTime postedDate, DateTime modifiedDate)
          {
               Id = id;
               Title = title;
               Solution = solution;
               SolutionLink = solutionLink;
               Details = details;
               PostedDate = postedDate;
               ModifiedDate = modifiedDate;
          }

          public void clear()
          {
               Id = 0;
               Title = "";
               Solution = "";
               SolutionLink = "";
               Details = "";
               PostedDate = new DateTime();
               PostedDate = new DateTime();
          }
     }
}
