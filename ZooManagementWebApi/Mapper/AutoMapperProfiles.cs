using AutoMapper;
using Domain.Entities;
using ZooManagementWebApi.DTOs;
namespace ZooManagementWebApi.Mapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AnimalInformation, AnimalInformation>().ReverseMap();
        }
    }
}
