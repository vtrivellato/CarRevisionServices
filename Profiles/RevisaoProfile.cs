using api.DTOs.Revisao;
using api.Models;
using AutoMapper;

namespace api.Profiles
{
    public class RevisoesProfile : Profile
    {
        public RevisoesProfile()
        {
            CreateMap<Revisao, RevisaoReadDTO>();
            CreateMap<RevisaoCreateDTO, Revisao>();
            CreateMap<RevisaoUpdateDTO, Revisao>();
            CreateMap<Revisao, RevisaoUpdateDTO>();
        }
    }
}