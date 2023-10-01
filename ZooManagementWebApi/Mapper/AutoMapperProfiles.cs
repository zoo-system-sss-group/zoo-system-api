using AutoMapper;
using Domain.Entities;
using ZooManagementWebApi.DTOs;
namespace ZooManagementWebApi.Mapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AnimalInformationDto, AnimalInformation>().ReverseMap();
            CreateMap<SpeciesDto, Species>().ReverseMap();
            CreateMap<AreaDto, Area>().ReverseMap();
            CreateMap<CageDto, Cage>().ReverseMap();
            CreateMap<DietDto, Diet>().ReverseMap();
            CreateMap<TicketDTO, News>().ReverseMap();
        }
    }
}
