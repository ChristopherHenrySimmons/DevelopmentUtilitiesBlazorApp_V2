using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
     public class CodeBlock_V2
     {
          public int Id { get; set; }
          public string Title { get; set; }
          public string Block { get; set; }
          public string Langue { get; set; }
          public string Function { get; set; }
          public DateTime PostedDate { get; set; }
          public DateTime ModifiedDate { get; set; }

          public CodeBlock_V2()
          {

          }


          public CodeBlock_V2(int id, string title, string block, string langue, string function, DateTime postedDate, DateTime modifiedDate)
          {
               Id = id;
               Title = title;
               Block = block;
               Langue = langue;
               Function = function;
               PostedDate = postedDate;
               ModifiedDate = modifiedDate;
          }

          public void clear()
          {
               Id = 0;
               Title = "";
               Block = "";
               Langue = "";
               Function = "";
               PostedDate = new DateTime();
               PostedDate = new DateTime();
          }
     }
}
