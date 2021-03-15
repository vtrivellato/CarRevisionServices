using api.DTOs.Cor;
using api.Models;
using AutoMapper;

namespace api.Profiles
{
    public class CoresProfile : Profile
    {
        public CoresProfile()
        {
            CreateMap<Cor, CorReadDTO>();
        }
    }
}