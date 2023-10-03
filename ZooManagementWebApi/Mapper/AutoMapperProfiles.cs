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
            CreateMap<NewsDTO, News>().ReverseMap();
            CreateMap<TicketUpdateDTO, Ticket>().ReverseMap();
            CreateMap<TicketCreateDTO, Ticket>().ReverseMap();
            CreateMap<TicketOrderDTO, TicketOrder>().ReverseMap();
            CreateMap<TicketOrderViewDTO, TicketOrder>().ReverseMap();
            CreateMap<TicketViewDTO, Ticket>().ReverseMap();
        }
    }
}
