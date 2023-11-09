using CommandsAPI.Models;
using System;
using System.Collections.Generic;

namespace CommandsAPI.Data
{
    // This class is a mock repository implementation for managing Command entities.
    public class MockCommandAPIRepo : ICommandAPIRepo
    {
        public void CreateCommand(Command cmd)
        {
            // Implementation is not provided in this mock repository.
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            // Implementation is not provided in this mock repository.
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            // Return a collection of mock Command entities for testing and development.
            var commands = new List<Command>
            {
                new Command
                {
                    Id = 0,
                    HowTo = "How to generate a migration",
                    CommandLine = "dotnet ef migrations add <Name of Migration>",
                    Platform = ".Net Core EF"
                },
                new Command
                {
                    Id = 1,
                    HowTo = "Run Migrations",
                    CommandLine = "dotnet ef database update",
                    Platform = ".Net Core EF"
                },
                new Command
                {
                    Id = 2,
                    HowTo = "List active migrations",
                    CommandLine = "dotnet ef migrations list",
                    Platform = ".Net Core EF"
                }
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            // Return a mock Command entity with default values.
            return new Command
            {
                Id = 0,
                HowTo = "How to generate a migration",
                CommandLine = "dotnet ef migrations add <name of migration>",
                Platform = ".Net Core EF"
            };
        }

        public bool SaveChanges()
        {
            // Implementation is not provided in this mock repository.
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            // Implementation is not provided in this mock repository.
            throw new NotImplementedException();
        }
    }
}
