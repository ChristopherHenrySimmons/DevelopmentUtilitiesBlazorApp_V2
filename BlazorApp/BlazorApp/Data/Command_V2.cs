using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
     public class Command_V2
     {
          public int Id { get; set; }

          [Required(ErrorMessage = "Title is missing")]
          public string Title { get; set; }
          [Required(ErrorMessage = "Command is missing")]
          public string Command { get; set; }
          [Required(ErrorMessage = "Console Type is missing")]
          public string ConsoleType { get; set; }
          [Required(ErrorMessage = "Date Posted is missing")]
          public DateTime PostedDate { get; set; }
          [Required(ErrorMessage = "Date Modified is missing")]
          public DateTime ModifiedDate { get; set; }

          public Command_V2()
          {

          }


          public Command_V2(int id, string title, string command, string consoleType, DateTime postedDate, DateTime modifiedDate)
          {
               Id = id;
               Title = title;
               Command = command;
               ConsoleType = consoleType;
               PostedDate = postedDate;
               ModifiedDate = modifiedDate;
          }

          public void clear()
          {
               Id = 0;
               Title = "";
               Command = "";
               ConsoleType = "";
               PostedDate = new DateTime();
               PostedDate = new DateTime();
          }
     }
}
