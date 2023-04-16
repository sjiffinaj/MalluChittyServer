using AutoMapper;
using MChitty.DTO;
using MChitty.Entity;

namespace MChitty.Helpers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Chitty, ChittyDto>();
        }
    }
}