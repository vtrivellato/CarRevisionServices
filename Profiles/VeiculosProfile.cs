using api.DTOs.Veiculo;
using api.Models;
using AutoMapper;

namespace api.Profiles
{
    public class VeiculosProfile : Profile
    {
        public VeiculosProfile()
        {
            CreateMap<Veiculo, VeiculoReadDTO>();
            CreateMap<VeiculoCreateDTO, Veiculo>();
            CreateMap<VeiculoUpdateDTO, Veiculo>();
            CreateMap<Veiculo, VeiculoUpdateDTO>();
        }
    }
}