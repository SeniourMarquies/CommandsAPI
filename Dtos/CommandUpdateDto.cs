using System.ComponentModel.DataAnnotations;

namespace CommandsAPI.Dtos
{
    // This class represents a Data Transfer Object (DTO) for updating an existing Command.
    public class CommandUpdateDto
    {
        // The HowTo property represents the updated instructions for the command.
        // It is required and has a maximum length of 250 characters.
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        // The Platform property represents the updated platform where the command is applicable.
        // It is required.
        [Required]
        public string Platform { get; set; }

        // The CommandLine property represents the updated actual command line input.
        // It is required.
        [Required]
        public string CommandLine { get; set; }
    }
}
