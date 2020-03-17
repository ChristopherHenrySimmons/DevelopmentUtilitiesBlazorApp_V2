using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    interface ICommandService
    {
        Task<List<CommandData>> GetCommands();
        Task<CommandData> GetCommandById(int Id);
        Task<bool> SaveCommand(CommandData Command);
        Task<bool> DeleteCommand(string Id);
    }
}
