using System;
using System.Collections.Generic;
using System.Linq;
using api.Data.Contexts;
using api.Data.Repositories;
using api.DTOs.Fabricante;
using api.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    // api/fabricantes
    [Route("api/[controller]")]
    [ApiController]
    public class FabricantesController : Controller
    {
        private readonly IFabricanteRepository _repository;
        private readonly IMapper _mapper;

        public FabricantesController(IFabricanteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET api/fabricantes/
        [HttpGet]
        public ActionResult<IEnumerable<FabricanteReadDTO>> Get()
        {
            var fabricantes = _repository.GetAllFabricantes();
            fabricantes = fabricantes.OrderBy(x => x.Nome);

            return Ok(_mapper.Map<IEnumerable<FabricanteReadDTO>>(fabricantes));
        }
    }
}