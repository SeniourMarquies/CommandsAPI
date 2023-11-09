using CommandsAPI.Models;

namespace CommandsAPI.Data
{
    // This interface defines the contract for a repository that manages Command entities.
    public interface ICommandAPIRepo
    {
        // SaveChanges method is used to persist changes to the database.
        bool SaveChanges();

        // GetAllCommands method retrieves all Command entities.
        IEnumerable<Command> GetAllCommands();

        // GetCommandById method retrieves a Command entity by its unique identifier.
        Command GetCommandById(int id);

        // CreateCommand method adds a new Command entity to the repository.
        void CreateCommand(Command cmd);

        // UpdateCommand method updates an existing Command entity in the repository.
        void UpdateCommand(Command cmd);

        // DeleteCommand method removes an existing Command entity from the repository.
        void DeleteCommand(Command cmd);
    }
}
