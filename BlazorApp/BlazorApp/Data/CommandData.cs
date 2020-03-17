using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
     public class CommandData
     {
          public int Id { get; set; }

          [Required(ErrorMessage = "Title is missing")]
          public string Title { get; set; }
          [Required(ErrorMessage = "Command is missing")]
          public string Command { get; set; }
          [Required(ErrorMessage = "Console Type is missing")]
          public string ConsoleType { get; set; }
          public DateTime PostedDate { get; set; }
          public DateTime ModifiedDate { get; set; }

          public CommandData()
          {

          }


          public CommandData(int id, string title, string command, string consoleType, DateTime postedDate, DateTime modifiedDate)
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
