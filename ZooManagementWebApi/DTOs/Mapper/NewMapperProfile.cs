using AutoMapper;
using Domain.Entities;

namespace ZooManagementWebApi.DTOs.Mapper
{
    // hien tai chua biet de dau nen de day
    public class NewMapperProfile : Profile
    {
        protected NewMapperProfile()
        {
            CreateMap<NewsDTO, News>();
        }
    }
}
