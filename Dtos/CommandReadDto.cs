namespace CommandsAPI.Dtos
{
    // This class represents a Data Transfer Object (DTO) for reading (or displaying) Command information.
    public class CommandReadDto
    {
        // The Id property represents the unique identifier for the command.
        public int Id { get; set; }

        // The HowTo property represents the instructions for the command.
        public string HowTo { get; set; }

        // public string Platform {get; set;} // this is commented to test mapper.

        // The CommandLine property represents the actual command line input.
        public string CommandLine { get; set; }
    }
}
