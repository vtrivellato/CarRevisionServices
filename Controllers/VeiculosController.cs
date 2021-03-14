using System.Collections.Generic;
using api.Data;
using api.DTOs;
using api.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    // api/veiculos
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculosController : Controller
    {
        private readonly IVeiculoRepository _repository;
        private readonly IMapper _mapper;

        public VeiculosController(IVeiculoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET api/veiculos/
        [HttpGet]
        public ActionResult<IEnumerable<VeiculoReadDTO>> GetAllVeiculos()
        {
            var veiculos = _repository.GetAllVeiculos();

            return Ok(_mapper.Map<IEnumerable<VeiculoReadDTO>>(veiculos));
        }

        // GET api/veiculos/{chassi}
        [HttpGet("{chassi}", Name="GetVeiculoByPK")]
        public ActionResult<VeiculoReadDTO> GetVeiculoByPK(string chassi)
        {
            var veiculo = _repository.GetveiculoByPK(chassi);

            if (veiculo == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<VeiculoReadDTO>(veiculo));
        }

        // POST api/veiculos
        [HttpPost]
        public ActionResult<VeiculoReadDTO> CreateVeiculo([FromBody] VeiculoCreateDTO veiculoCreateDTO)
        {
            var veiculo = _mapper.Map<Veiculo>(veiculoCreateDTO);

            _repository.Create(veiculo);

            if (!_repository.SaveChanges())
            {

            }

            var veiculoReadDTO = _mapper.Map<VeiculoReadDTO>(veiculo);

            return CreatedAtRoute(nameof(GetVeiculoByPK), new { Chassi = veiculoReadDTO.Chassi }, veiculoReadDTO);
        }
    }
}