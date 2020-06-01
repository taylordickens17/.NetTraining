using System.Collections.Generic;
using Commander.Models;

//This is the interface
namespace Commander.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}