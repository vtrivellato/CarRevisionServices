using api.DTOs.Modelo;
using api.Models;
using AutoMapper;

namespace api.Profiles
{
    public class ModelosProfile : Profile
    {
        public ModelosProfile()
        {
            CreateMap<Modelo, ModeloReadDTO>();
        }
    }
}