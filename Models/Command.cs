using System.ComponentModel.DataAnnotations;

namespace CommandsAPI.Models
{
    // This class represents a model for a command entity.
    public class Command
    {
        // The Id property serves as the primary key for the Command entity.
        [Key]
        [Required]
        public int Id { get; set; }

        // The HowTo property represents the instructions for the command.
        // It is required and has a maximum length of 250 characters.
        [Required]
        [MaxLength(250, ErrorMessage = "You've just reached MaxLength and exceeded it.")]
        public string HowTo { get; set; }

        // The Platform property represents the platform where the command is applicable.
        // It is required.
        [Required]
        public string Platform { get; set; }

        // The CommandLine property represents the actual command line input.
        // It is required.
        [Required]
        public string CommandLine { get; set; }
    }
}
