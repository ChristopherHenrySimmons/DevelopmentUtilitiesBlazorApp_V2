using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
     public class Resource_V2
     {
          public int Id { get; set; }
          public string Title { get; set; }
          public string Description { get; set; }
          public string Link { get; set; }
          public string Langues { get; set; }
          public DateTime PostedDate { get; set; }
          public DateTime ModifiedDate { get; set; }

          public Resource_V2()
          {

          }


          public Resource_V2(int id, string title, string description, string link, string langues, DateTime postedDate, DateTime modifiedDate)
          {
               Id = id;
               Title = title;
               Description = description;
               Link = link;
               Langues = langues;
               PostedDate = postedDate;
               ModifiedDate = modifiedDate;
          }

          public void clear()
          {
               Id = 0;
               Title = "";
               Description = "";
               Link = "";
               Langues = "";
               PostedDate = new DateTime();
               PostedDate = new DateTime();
          }
     }
}
