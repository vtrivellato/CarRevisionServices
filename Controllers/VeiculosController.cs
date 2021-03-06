using System.Collections.Generic;
using api.Data.Repositories;
using api.DTOs.Veiculo;
using api.Models;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
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
        public ActionResult<IEnumerable<VeiculoReadDTO>> Get()
        {
            var veiculos = _repository.GetAllVeiculos();

            return Ok(_mapper.Map<IEnumerable<VeiculoReadDTO>>(veiculos));
        }

        // GET api/veiculos/{chassi}
        [HttpGet("{chassi}", Name="GetVeiculoById")]
        public ActionResult<VeiculoReadDTO> GetVeiculoById(string chassi)
        {
            var veiculo = _repository.GetVeiculoByPK(chassi);

            if (veiculo == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<VeiculoReadDTO>(veiculo));
        }

        // POST api/veiculos
        [HttpPost]
        public ActionResult<VeiculoReadDTO> Post([FromBody] VeiculoCreateDTO veiculoCreateDTO)
        {
            var veiculo = _mapper.Map<Veiculo>(veiculoCreateDTO);

            _repository.Create(veiculo);

            if (!_repository.SaveChanges())
            {

            }

            var veiculoReadDTO = _mapper.Map<VeiculoReadDTO>(veiculo);

            return CreatedAtRoute(nameof(GetVeiculoById), new { Chassi = veiculoReadDTO.Chassi }, veiculoReadDTO);
        }

        // PUT api/veiculos/{chassi}
        [HttpPut("{chassi}")]
        public ActionResult Put(string chassi, [FromBody] VeiculoUpdateDTO veiculoUpdateDTO)
        {
            var veiculoFromRepository = _repository.GetVeiculoByPK(chassi);

            if (veiculoFromRepository == null)
            {
                return NotFound();
            }

            _mapper.Map(veiculoUpdateDTO, veiculoFromRepository);

            _repository.Update(veiculoFromRepository);

            if (!_repository.SaveChanges())
            {

            }

            return NoContent();
        }

        // PATCH api/veiculos/{chassi}
        [HttpPatch("{chassi}")]
        public ActionResult Patch(string chassi, [FromBody] JsonPatchDocument<VeiculoUpdateDTO> patchDocument)
        {
            var veiculoFromRepository = _repository.GetVeiculoByPK(chassi);

            if (veiculoFromRepository == null)
            {
                return NotFound();
            }

            var veiculoToPatch = _mapper.Map<VeiculoUpdateDTO>(veiculoFromRepository);
            patchDocument.ApplyTo(veiculoToPatch, ModelState);
            
            if (!TryValidateModel(veiculoToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(veiculoToPatch, veiculoFromRepository);

            _repository.Update(veiculoFromRepository);

            if (!_repository.SaveChanges())
            {

            }

            return NoContent();
        }

        // DELETE api/veiculos/{chassi}
        [HttpDelete("{chassi}")]
        public ActionResult Delete(string chassi)
        {
            var veiculoFromRepository = _repository.GetVeiculoByPK(chassi);

            if (veiculoFromRepository == null)
            {
                return NotFound();
            }

            _repository.Delete(veiculoFromRepository);

            if (!_repository.SaveChanges())
            {

            }

            return NoContent();
        }
    }
}