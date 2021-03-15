using System.Collections.Generic;
using api.Data.Contexts;
using api.Data.Repositories;
using api.DTOs.Modelo;
using api.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    // api/modelos
    [Route("api/[controller]")]
    [ApiController]
    public class ModelosController : Controller
    {
        private readonly IModeloRepository _repository;
        private readonly IMapper _mapper;

        public ModelosController(IModeloRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET api/modelos/
        [HttpGet]
        public ActionResult<IEnumerable<ModeloReadDTO>> Get([FromQuery] int? fabricante)
        {
            var modelos = _repository.GetAllModelos(fabricante);

            return Ok(_mapper.Map<IEnumerable<ModeloReadDTO>>(modelos));
        }
    }
}