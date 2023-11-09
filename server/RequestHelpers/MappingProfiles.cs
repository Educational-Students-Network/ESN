using AutoMapper;
using server.DTOs;
using server.Entities;

namespace server.RequestHelpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CreateEventDto, Event>();
    }
}