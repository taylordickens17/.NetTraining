using System.Collections.Generic;
using Commander.Models;

//This is the interface
namespace Commander.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();

        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
    }
}