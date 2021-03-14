using System.Collections.Generic;
using api.Data.Contexts;
using api.Data.Repositories;
using api.DTOs.Revisao;
using api.Models;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    // api/revisoes
    [Route("api/[controller]")]
    [ApiController]
    public class RevisoesController : Controller
    {
        private readonly IRevisaoRepository _repository;
        private readonly IMapper _mapper;

        public RevisoesController(IRevisaoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET api/revisoes/
        [HttpGet]
        public ActionResult<IEnumerable<RevisaoReadDTO>> Get()
        {
            var revisoes = _repository.GetAllRevisoes();

            return Ok(_mapper.Map<IEnumerable<RevisaoReadDTO>>(revisoes));
        }

        // GET api/revisoes/{chassi}
        [HttpGet("{chassi}", Name = "GetRevisaoById")]
        public ActionResult<IEnumerable<RevisaoReadDTO>> GetRevisaoById(string chassi, [FromQuery] double km)
        {
            if (km > 0)
            {
                var revisao = _repository.GetRevisaoByPK(chassi, km);

                if (revisao == null)
                {
                    return NotFound();
                }

                return Ok(_mapper.Map<RevisaoReadDTO>(revisao));
            }
            else
            {
                var revisoes = _repository.GetAllRevisoes(chassi);

                return Ok(_mapper.Map<IEnumerable<RevisaoReadDTO>>(revisoes));
            }
        }

        // POST api/revisoes
        [HttpPost]
        public ActionResult<RevisaoReadDTO> Post([FromBody] RevisaoCreateDTO revisaoCreateDTO)
        {
            var revisao = _mapper.Map<Revisao>(revisaoCreateDTO);

            _repository.Create(revisao);

            if (!_repository.SaveChanges())
            {

            }

            var revisaoReadDTO = _mapper.Map<RevisaoReadDTO>(revisao);

            return CreatedAtRoute(nameof(GetRevisaoById), new { Chassi = revisaoReadDTO.Chassi, Km = revisaoReadDTO.Km }, revisaoReadDTO);
        }

        // PUT api/revisoes/{chassi}
        [HttpPut("{chassi}")]
        public ActionResult Put(string chassi, [FromQuery] double km, [FromBody] RevisaoUpdateDTO revisaoUpdateDTO)
        {
            var revisaoFromRepository = _repository.GetRevisaoByPK(chassi, km);

            if (revisaoFromRepository == null)
            {
                return NotFound();
            }

            _mapper.Map(revisaoUpdateDTO, revisaoFromRepository);

            _repository.Update(revisaoFromRepository);

            if (!_repository.SaveChanges())
            {

            }

            return NoContent();
        }

        // PATCH api/revisoes/{chassi}
        [HttpPatch("{chassi}")]
        public ActionResult Patch(string chassi, [FromQuery] double km, [FromBody] JsonPatchDocument<RevisaoUpdateDTO> patchDocument)
        {
            var revisaoFromRepository = _repository.GetRevisaoByPK(chassi, km);

            if (revisaoFromRepository == null)
            {
                return NotFound();
            }

            var revisaoToPatch = _mapper.Map<RevisaoUpdateDTO>(revisaoFromRepository);
            patchDocument.ApplyTo(revisaoToPatch, ModelState);

            if (!TryValidateModel(revisaoToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(revisaoToPatch, revisaoFromRepository);

            _repository.Update(revisaoFromRepository);

            if (!_repository.SaveChanges())
            {

            }

            return NoContent();
        }

        // DELETE api/revisoes/{chassi}
        [HttpDelete("{chassi}")]
        public ActionResult Delete(string chassi, [FromQuery] double km)
        {
            var revisaoFromRepository = _repository.GetRevisaoByPK(chassi, km);

            if (revisaoFromRepository == null)
            {
                return NotFound();
            }

            _repository.Delete(revisaoFromRepository);

            if (!_repository.SaveChanges())
            {

            }

            return NoContent();
        }
    }
}