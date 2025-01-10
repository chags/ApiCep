using apiCep.Models;
using apiCep.Services;
using Microsoft.AspNetCore.Mvc;

namespace apiCep.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class CepController : ControllerBase
    {
        private readonly CepService _cepService;

        public CepController(CepService cepService)
        {
            _cepService = cepService;
        }

        [HttpGet("{cep}")]
        public IActionResult GetCepInfo(string cep)
        {
            // Validate the CEP
            var validation = _cepService.ValidateCep(cep);
            if (!validation.IsValid)
            {
                return BadRequest(new { Error = validation.ErrorMessage });
            }

            // Fetch CEP information
            var cepInfo = _cepService.GetCepInfo(cep);
            if (cepInfo == null)
            {
                return NotFound(new { Error = "CEP not found." });
            }

            return Ok(cepInfo);
        }
    }
}
