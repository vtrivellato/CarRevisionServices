using System.Collections.Generic;
using api.Data;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    // api/veiculos
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculosController : Controller
    {
        private readonly IVeiculoRepository _repository;

        public VeiculosController(IVeiculoRepository repository)
        {
            _repository = repository;
        }

        // GET api/veiculos/
        [HttpGet]
        public ActionResult<IEnumerable<Veiculo>> GetAllVeiculos()
        {
            var veiculos = _repository.GetAllVeiculos();

            return Ok(veiculos);
        }

        // GET api/veiculos/{chassi}
        [HttpGet("{chassi}")]
        public ActionResult<Veiculo> GetVeiculoByPK(string chassi)
        {
            var veiculo = _repository.GetveiculoByPK(chassi);

            return Ok(veiculo);
        }
    }
}