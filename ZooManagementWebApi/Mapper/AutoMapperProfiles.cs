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
            CreateMap<DietDto, Diet>().ReverseMap();
            CreateMap<CageHistoryDto, CageHistory>().ReverseMap();
            CreateMap<FeedHistoryDto, FeedHistory>().ReverseMap();
            // Accounts
            CreateMap<Account, AccountDto>().ReverseMap();

            // Tickets           
            CreateMap<Ticket, TicketUpdateDto>().ReverseMap();
            CreateMap<TicketOrder, TicketOrderDto>().ForMember(x => x.Tickets, opt => opt.Ignore());
            CreateMap<TicketOrderDto, TicketOrder>().ForMember(x => x.Tickets, opt => opt.Ignore());

            CreateMap<TrainingDetail, TrainingDetailDto>().ReverseMap();
        }
    }
}
