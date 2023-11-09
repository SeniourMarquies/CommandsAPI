using CommandsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandsAPI.Data
{
    // This class is a repository implementation for managing Command entities using a SQL database.
    public class SqlCommandAPIRepo : ICommandAPIRepo
    {
        private readonly CommandContext _context;

        // Constructor that injects the CommandContext dependency.
        public SqlCommandAPIRepo(CommandContext context)
        {
            _context = context;
        }

        // CreateCommand method adds a new Command entity to the database.
        public void CreateCommand(Command cmd)
        {
            if (cmd == null) throw new ArgumentNullException(nameof(cmd));
            _context.CommandItems.Add(cmd); // Add cmd to the CommandItems DbSet.
        }

        // DeleteCommand method removes a Command entity from the database.
        public void DeleteCommand(Command cmd)
        {
            if (cmd == null) throw new ArgumentException(nameof(cmd));
            _context.CommandItems.Remove(cmd);
        }

        // GetAllCommands method retrieves all Command entities from the database.
        public IEnumerable<Command> GetAllCommands()
        {
            return _context.CommandItems.ToList();
        }

        // GetCommandById method retrieves a Command entity by its unique identifier from the database.
        public Command GetCommandById(int id)
        {
            return _context.CommandItems.FirstOrDefault(p => p.Id == id);
        }

        // SaveChanges method persists changes to the database and returns a boolean indicating the status.
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        // UpdateCommand method is not implemented as the repository interface is technology-agnostic.
        // A specific implementation may require this method in the future if the persistence provider changes.
        public void UpdateCommand(Command cmd)
        {
            // We don't need to do anything here.
            // The repository interface is technology-agnostic, so while we don't require an implementation in this instance, if we choose to switch our persistence provider, they may require a coded implementation.
        }
    }
}
