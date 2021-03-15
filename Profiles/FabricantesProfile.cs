using api.DTOs.Fabricante;
using api.Models;
using AutoMapper;

namespace api.Profiles
{
    public class FabricantesProfile : Profile
    {
        public FabricantesProfile()
        {
            CreateMap<Fabricante, FabricanteReadDTO>();
        }
    }
}