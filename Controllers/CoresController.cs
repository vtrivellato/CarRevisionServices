using System.Collections.Generic;
using api.Data.Contexts;
using api.Data.Repositories;
using api.DTOs.Cor;
using api.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    // api/cores
    [Route("api/[controller]")]
    [ApiController]
    public class CoresController : Controller
    {
        private readonly ICorRepository _repository;
        private readonly IMapper _mapper;

        public CoresController(ICorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET api/cores/
        [HttpGet]
        public ActionResult<IEnumerable<CorReadDTO>> Get([FromQuery] int? fabricante)
        {
            var cores = _repository.GetAllCores(fabricante);

            return Ok(_mapper.Map<IEnumerable<CorReadDTO>>(cores));
        }
    }
}