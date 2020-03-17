using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
     public class CommandService : ICommandService
     {
          public List<CommandData> Commands { get; set; }

          public CommandService()
          {
               //throw new Exception("CommandServiceException");

               Commands = new List<CommandData>();

               Commands.Add(new CommandData(1, "Title", "Command", "ConsoleType", DateTime.Now, DateTime.Now));
               Commands.Add(new CommandData(2, "Title", "Command", "ConsoleType", DateTime.Now, DateTime.Now));
               Commands.Add(new CommandData(3, "Title", "Command", "ConsoleType", DateTime.Now, DateTime.Now));
               Commands.Add(new CommandData(4, "Title", "Command", "ConsoleType", DateTime.Now, DateTime.Now));
               Commands.Add(new CommandData(5, "Title", "Command", "ConsoleType", DateTime.Now, DateTime.Now));
          }

          public async Task<List<CommandData>> GetCommands()
          {
               return await Task.FromResult(Commands);
          }

          public async Task<CommandData> GetCommandById(int CommandId)
          {
               return await Task.FromResult(Commands.Where(auth => auth.Id == CommandId).FirstOrDefault());
          }

          public async Task<bool> SaveCommand(CommandData Command)
          {
               //Command.CommandId = GetNewCommand();
               Commands.Add(Command);
               return await Task.FromResult(true);
          }

          private string GetNewCommand()
          {
               string id;
               Random random = new Random();
               id = random.Next(100, 1000).ToString() + "-";
               id += random.Next(10, 100).ToString() + "-";
               id += random.Next(1000, 10000).ToString();

               return id;
          }

          public async Task<bool> DeleteCommand(string CommandId)
          {
               return await Task.FromResult(true);
          }
     }
}
