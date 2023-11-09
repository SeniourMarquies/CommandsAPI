using System.ComponentModel.DataAnnotations;

namespace CommandsAPI.Dtos
{
    // This class represents a Data Transfer Object (DTO) for creating a new Command.
    public class CommandCreateDto
    {
        // The HowTo property represents the instructions for the command.
        // It is required and has a maximum length of 250 characters.
        [Required]
        [MaxLength(250)]
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
