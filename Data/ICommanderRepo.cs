using System.Collections.Generic;
using Commander.Models;

//This is the interface
namespace Commander.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
    }
}