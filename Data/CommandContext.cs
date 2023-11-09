using CommandsAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CommandsAPI.Data
{
    // This class represents the database context for the application, derived from DbContext.
    public class CommandContext : DbContext
    {
        public CommandContext(DbContextOptions options) : base(options)
        {
        }

        // DbSet property for the Command entity, allowing database operations on the CommandItems table.
        public DbSet<Command> CommandItems { get; set; }
    }
}
