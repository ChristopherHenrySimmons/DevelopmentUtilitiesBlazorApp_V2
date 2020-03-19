using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    interface ICommandService
    {
        Task<List<Command_V2>> GetCommands();
        Task<Command_V2> GetCommandById(int Id);
        Task<bool> SaveCommand(Command_V2 Command);
        Task<bool> DeleteCommand(string Id);
    }
}
