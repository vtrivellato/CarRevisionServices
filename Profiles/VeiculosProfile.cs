using api.DTOs;
using api.Models;
using AutoMapper;

namespace api.Profiles
{
    public class VeiculosProfile : Profile
    {
        public VeiculosProfile()
        {
            CreateMap<Veiculo, VeiculoReadDTO>();
        }
    }
}