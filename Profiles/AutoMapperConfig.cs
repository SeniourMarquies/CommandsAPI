using CommandsAPI.Dtos;
using CommandsAPI.Models;
using AutoMapper;

namespace CommandsAPI.Profiles
{
    // This class defines an AutoMapper configuration to map objects between Command, CommandReadDto, CommandCreateDto, and CommandUpdateDto.
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            // Define mapping rules for Command to CommandReadDto and vice versa.
            CreateMap<Command, CommandReadDto>().ReverseMap();

            // Define mapping rules for Command to CommandCreateDto and vice versa.
            CreateMap<Command, CommandCreateDto>().ReverseMap();

            // Define mapping rules for CommandUpdateDto to Command and vice versa.
            CreateMap<CommandUpdateDto, Command>().ReverseMap();
        }
    }
}
