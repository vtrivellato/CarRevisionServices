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
        private readonly MockveiculoRepository _repository = new MockveiculoRepository();

        // GET api/veiculos/
        [HttpGet]
        public ActionResult<IEnumerable<Veiculo>> GetAllVeiculos()
        {
            var veiculos = _repository.GetVeiculos();

            return Ok(veiculos);
        }

        // GET api/veiculos/{id}
        [HttpGet("{id}")]
        public ActionResult<Veiculo> GetVeiculoById(int id)
        {
            var veiculo = _repository.GetveiculoById(id);

            return Ok(veiculo);
        }
    }
}